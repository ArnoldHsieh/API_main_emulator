using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_main_emulator
{
    public partial class Form1 : Form
    {
        protocol EFEM = new protocol();
        private Thread EFEM_recive;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            EFEM.Initial();
            EFEM_recive = new Thread(Receive);
            EFEM_recive.IsBackground = true;
            EFEM_recive.Start();
            
        }
        private void Receive() 
        {
            while (true) 
            {
                string message;
                protocol.read_log(out message);
                if (string.IsNullOrEmpty(message))
                    continue;
                this.Invoke(new MethodInvoker(delegate () { textBox1.Text += (message+"\r\n"); }));
            }

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            protocol.send(txt_send.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_send.Text = "Remote,API";
        }

        private void commend_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox box = (ListBox)sender;
            txt_send.Text = box.SelectedItem.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_send.Text = "ResetError,Aligner1";
        }
    }
}
