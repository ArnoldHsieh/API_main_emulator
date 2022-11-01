using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace API_main_emulator
{
    internal class protocol
    {
        static TCP_client client = new TCP_client();
        static subscriber user_txb = new subscriber("txt");//新增訂閱用戶
        static subscriber reply_F100 = new subscriber("reply_F100");

        private static object _F100Lock = new object();//卡

        public void Initial()
        {
            client.ini();
            client.create_subscriber(user_txb, "txt");
            client.add_subscribe(user_txb);
        }
        public static void read_log(out string str)
        {
            str = "";
            client.read(user_txb, out str);
        }
        public static void send(string str)
        {
            client.send(str);
        }
        public static bool check_connection()//F100
        {
            lock (_F100Lock)
            {
                string anser = "";
                string[] anser_Split;
                int times = 0;
                bool success = false;
                subscriber Subscriber = reply_F100;

                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Interval = 100; // 觸發時間
                timer.AutoReset = true; // 重複觸發
                timer.Elapsed += (s, e) => // 觸發時執行的事件
                {
                    times++;
                };
                timer.Start(); // 啟動定時器
                client.add_subscribe(Subscriber);//順序需要測試
                client.send("F100");
                while (true)
                {
                    client.read(Subscriber, out anser);
                    anser_Split = anser.Split(',');
                    if (anser_Split[0] == "F100" && anser_Split.Length == 2)
                    {
                        break;
                    }
                    if (times > 10)
                        break;
                }
                if (times > 10)//timeout check
                    Console.WriteLine("timeout");
                else if (anser_Split[0] == "F100" && anser_Split.Length == 2)
                {
                    success = true;
                    if (anser_Split[1] == "1")
                    {

                        Console.WriteLine("complete");
                    }
                    else
                    {
                        success = false;
                        Console.WriteLine("wrong ans");
                    }
                }
                else//理論上不會發生
                {
                    Console.WriteLine("wrong ans");
                }
                client.unsubscribe(Subscriber);
                timer.Stop();
                timer.Close();
                return success;
            }
        }
    }

    class TCP_client
    {
        newspaper_office Newsboy = new newspaper_office("Main");  // 發送者   (將接收的資料發送給訂閱者 ) 
        // subscriber subscriber_1 = new subscriber("log");                 // 訂閱者1 未使用
        // subscriber subscriber_2 = new subscriber("Ben");                 // 訂閱者2 未使用

        //Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket clientSocket;
        private Thread TD_Server;

        public void ini()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //clientSocket.Connect(new IPEndPoint(IPAddress.Parse("192.168.1.23"), 502));

            try
            {
                //clientSocket.Connect(new IPEndPoint(IPAddress.Parse("192.168.1.23"), 4004));
                //clientSocket.Connect(new IPEndPoint(IPAddress.Parse("192.168.0.1"), 48879));
                clientSocket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 48879));
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            // Newsboy.Newsboy_Event += new newspaper_office.Newsboy_Handler(subscriber_1.get_paper);

            TD_Server = new Thread(Receive);
            TD_Server.IsBackground = true;
            TD_Server.Start();
        }
        public void create_subscriber(subscriber A, string name)
        {
            A = new subscriber(name);
        }
        public void add_subscribe(subscriber A)
        {
            Newsboy.Newsboy_Event += new newspaper_office.Newsboy_Handler(A.get_paper);
            Console.WriteLine("add_subscribe: {0}", A.name);
        }
        public void unsubscribe(subscriber A)
        {
            Newsboy.Newsboy_Event -= new newspaper_office.Newsboy_Handler(A.get_paper);
            Console.WriteLine("unsubscribe: {0}", A.name);
        }
        public void read(subscriber A, out string message)
        {
            string str = "";
            A.read_news(out str);
            message = str;
        }
        public void send(string str)
        {
            byte[] STX = new byte[] { 0x02 };
            byte[] EXT = new byte[] { 0x03 };
            byte[] date = new byte[1024];
            date = Encoding.UTF8.GetBytes(str);
            clientSocket.Send(STX);
            clientSocket.Send(date);
            clientSocket.Send(EXT);
        }

        private void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int r = clientSocket.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    //Console.WriteLine(str);
                    Newsboy.send_paper(str);
                    Thread.Sleep(1);
                }
            }
            catch
            {
                clientSocket.Close();
            }
        }

    }
    class newspaper_office
    {
        private string name;
        public newspaper_office(string name)
        {
            this.name = name;
        }
        // 委派(方法類別)
        public delegate void Newsboy_Handler(string a);

        // 事件(方法變數)
        public event Newsboy_Handler Newsboy_Event;

        public void send_paper(string str)
        {
            Console.WriteLine("Hi i am {0}", name);
            if (Newsboy_Event != null)
            {
                Newsboy_Event(str);
            }
        }

    }
    class subscriber
    {
        Queue<string> news = new Queue<string>();
        public string name;
        public subscriber(string name)
        {
            this.name = name;
        }
        public void get_paper(string a)//(string newspaper)
        {
            // string newspaper = "aaa";
            news.Enqueue(a);
            Console.WriteLine("send {1} to {0}", name, a);
        }
        public void get_paper(string a, Queue<string> otherQ)//(string newspaper)
        {
            // string newspaper = "aaa";
            otherQ.Enqueue(a);
            Console.WriteLine("send {1} to {0}", name, a);
        }

        public void read_news(out string message)
        {
            if (news.Count > 0)
                message = news.Dequeue();
            else
                message = "";
        }
    }
}
