
namespace API_main_emulator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_send = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(12, 41);
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(383, 22);
            this.txt_send.TabIndex = 12;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(401, 41);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 11;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(12, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(575, 233);
            this.textBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Remote,API";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(12, 12);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(100, 23);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "GetStatus,EFEM",
            "GetStatus,Robot1",
            "GetStatus,P1",
            "GetStatus,P2",
            "GetStatus,P3",
            "GetStatus,P4",
            "GetStatus,P5",
            "GetStatus,P6",
            "GetStatus,Aligner1"});
            this.listBox1.Location = new System.Drawing.Point(12, 309);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 148);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "Home,Robot1",
            "Home,P1",
            "Home,P2",
            "Home,P3",
            "Home,P4",
            "Home,P5",
            "Home,P6",
            "Home,Aligner1"});
            this.listBox2.Location = new System.Drawing.Point(12, 469);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(142, 132);
            this.listBox2.TabIndex = 14;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Items.AddRange(new object[] {
            "SetType,P1,0",
            "SetType,P1,1",
            "SetType,P2,0",
            "SetType,P2,1",
            "SetType,P3,0",
            "SetType,P3,1",
            "SetType,P4,0",
            "SetType,P4,1",
            "SetType,P5,0",
            "SetType,P5,1",
            "SetType,P6,0",
            "SetType,P6,1"});
            this.listBox3.Location = new System.Drawing.Point(160, 309);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(119, 292);
            this.listBox3.TabIndex = 14;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // listBox4
            // 
            this.listBox4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Items.AddRange(new object[] {
            "SetAlignerWaferType,Aligner2,04",
            "SetAlignerWaferType,Aligner2,05",
            "SetOCRJob,OCRReader1,0123456789AB.job",
            "ReadFoupID,RFID1",
            "Load,P1",
            "GetWaferSlot,P1",
            "GetWaferThickness,P1",
            "GetWaferPosition,P1",
            "WaferGet,Robot1,2,P1,1",
            "Home,Aligner1",
            "WaferPut,Robot1,2,Aligner1,1",
            "Read,OCRReader1",
            "AlignerVacuum,Aligner1,On",
            "Alignment,Aligner1,0",
            "AlignerVacuum,Aligner1,Off",
            "WaferGet,Robot1,1, Aligner1,1",
            "WaferPut,Robot1,1,Stage1,1",
            "WaferGet,Robot1,1,Stage1,1"});
            this.listBox4.Location = new System.Drawing.Point(593, 261);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(302, 340);
            this.listBox4.TabIndex = 14;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // listBox5
            // 
            this.listBox5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Items.AddRange(new object[] {
            "Stop,Robot1",
            "ReStart,Robot1",
            "SetRobotSpeed,Robot1,10,10",
            "ReadPosition,Robot1",
            "WaferGet,Robot1,2,P1,1",
            "WaferPut,Robot1,2,P1,1",
            "GetStandby,Robot1,2,P1,1",
            "PutStandby,Robot1,2,P1,1",
            "VacuumOn,Robot1,2",
            "VacuumOff,Robot1,2",
            "CheckWaferPresence,Robot1"});
            this.listBox5.Location = new System.Drawing.Point(299, 310);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(288, 180);
            this.listBox5.TabIndex = 14;
            this.listBox5.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // listBox6
            // 
            this.listBox6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 16;
            this.listBox6.Items.AddRange(new object[] {
            "Clamp,P1",
            "UnClamp,P1",
            "Load,P1",
            "Unload,P1",
            "Map,P1",
            "GetWaferSlot,P1",
            "GetWaferThickness,P1",
            "GetWaferPosition,P1",
            "SetType,P1,4",
            "GetMapp,P1,4",
            "GetProtrusionSensor,P1"});
            this.listBox6.Location = new System.Drawing.Point(593, 70);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(302, 180);
            this.listBox6.TabIndex = 14;
            this.listBox6.SelectedIndexChanged += new System.EventHandler(this.listBox6_SelectedIndexChanged);
            // 
            // listBox7
            // 
            this.listBox7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 16;
            this.listBox7.Items.AddRange(new object[] {
            "Home,Aligner1",
            "AlignerVacuum,Aligner1,On",
            "SetAlignerWaferType,Aligner1,04",
            "SetAlignerWaferType,Aligner1,05",
            "GetAlignerWaferType,Aligner1"});
            this.listBox7.Location = new System.Drawing.Point(299, 501);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(288, 100);
            this.listBox7.TabIndex = 14;
            this.listBox7.SelectedIndexChanged += new System.EventHandler(this.listBox7_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 624);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_send);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox7;
    }
}

