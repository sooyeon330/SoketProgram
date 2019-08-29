namespace SoketProgram
{
    partial class ServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_ip = new System.Windows.Forms.Label();
            this.lb_port = new System.Windows.Forms.Label();
            this.tbxIpS = new System.Windows.Forms.TextBox();
            this.tbxPortS = new System.Windows.Forms.TextBox();
            this.tbxChatHsS = new System.Windows.Forms.TextBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_ip
            // 
            this.lb_ip.AutoSize = true;
            this.lb_ip.Location = new System.Drawing.Point(15, 19);
            this.lb_ip.Name = "lb_ip";
            this.lb_ip.Size = new System.Drawing.Size(28, 12);
            this.lb_ip.TabIndex = 0;
            this.lb_ip.Text = "IP : ";
            // 
            // lb_port
            // 
            this.lb_port.AutoSize = true;
            this.lb_port.Location = new System.Drawing.Point(12, 46);
            this.lb_port.Name = "lb_port";
            this.lb_port.Size = new System.Drawing.Size(50, 12);
            this.lb_port.TabIndex = 1;
            this.lb_port.Text = "PORT : ";
            // 
            // tbxIpS
            // 
            this.tbxIpS.Location = new System.Drawing.Point(47, 10);
            this.tbxIpS.Name = "tbxIpS";
            this.tbxIpS.ReadOnly = true;
            this.tbxIpS.Size = new System.Drawing.Size(124, 21);
            this.tbxIpS.TabIndex = 2;
            // 
            // tbxPortS
            // 
            this.tbxPortS.Location = new System.Drawing.Point(68, 43);
            this.tbxPortS.Name = "tbxPortS";
            this.tbxPortS.Size = new System.Drawing.Size(103, 21);
            this.tbxPortS.TabIndex = 2;
            // 
            // tbxChatHsS
            // 
            this.tbxChatHsS.Location = new System.Drawing.Point(13, 86);
            this.tbxChatHsS.Multiline = true;
            this.tbxChatHsS.Name = "tbxChatHsS";
            this.tbxChatHsS.Size = new System.Drawing.Size(332, 311);
            this.tbxChatHsS.TabIndex = 4;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(275, 10);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(70, 54);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "종료하기";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(199, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(70, 54);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "시작하기";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 418);
            this.Controls.Add(this.tbxChatHsS);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbxPortS);
            this.Controls.Add(this.tbxIpS);
            this.Controls.Add(this.lb_port);
            this.Controls.Add(this.lb_ip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServerForm";
            this.Text = "ServerChat";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ip;
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.TextBox tbxIpS;
        private System.Windows.Forms.TextBox tbxPortS;
        private System.Windows.Forms.TextBox tbxChatHsS;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStart;
    }
}