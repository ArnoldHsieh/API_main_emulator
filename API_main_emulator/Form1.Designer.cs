
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
            this.btn_Home_Robot1 = new System.Windows.Forms.Button();
            this.btn_GetStatus_P1 = new System.Windows.Forms.Button();
            this.btn_check_cameras = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(12, 41);
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(341, 22);
            this.txt_send.TabIndex = 12;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(359, 41);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 11;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 341);
            this.textBox1.TabIndex = 10;
            // 
            // btn_Home_Robot1
            // 
            this.btn_Home_Robot1.Location = new System.Drawing.Point(199, 157);
            this.btn_Home_Robot1.Name = "btn_Home_Robot1";
            this.btn_Home_Robot1.Size = new System.Drawing.Size(105, 23);
            this.btn_Home_Robot1.TabIndex = 6;
            this.btn_Home_Robot1.Text = "Home,Robot1";
            this.btn_Home_Robot1.UseVisualStyleBackColor = true;
            this.btn_Home_Robot1.Click += new System.EventHandler(this.btn_Home_Robot1_Click);
            // 
            // btn_GetStatus_P1
            // 
            this.btn_GetStatus_P1.Location = new System.Drawing.Point(199, 127);
            this.btn_GetStatus_P1.Name = "btn_GetStatus_P1";
            this.btn_GetStatus_P1.Size = new System.Drawing.Size(105, 23);
            this.btn_GetStatus_P1.TabIndex = 7;
            this.btn_GetStatus_P1.Text = "GetStatus,P1";
            this.btn_GetStatus_P1.UseVisualStyleBackColor = true;
            this.btn_GetStatus_P1.Click += new System.EventHandler(this.btn_GetStatus_P1_Click);
            // 
            // btn_check_cameras
            // 
            this.btn_check_cameras.Location = new System.Drawing.Point(199, 98);
            this.btn_check_cameras.Name = "btn_check_cameras";
            this.btn_check_cameras.Size = new System.Drawing.Size(105, 23);
            this.btn_check_cameras.TabIndex = 8;
            this.btn_check_cameras.Text = "GetStatus,Robot1";
            this.btn_check_cameras.UseVisualStyleBackColor = true;
            this.btn_check_cameras.Click += new System.EventHandler(this.btn_check_cameras_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 69);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 624);
            this.Controls.Add(this.txt_send);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Home_Robot1);
            this.Controls.Add(this.btn_GetStatus_P1);
            this.Controls.Add(this.btn_check_cameras);
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
        private System.Windows.Forms.Button btn_Home_Robot1;
        private System.Windows.Forms.Button btn_GetStatus_P1;
        private System.Windows.Forms.Button btn_check_cameras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_connect;
    }
}

