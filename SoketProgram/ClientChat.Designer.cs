namespace SoketProgram
{
    partial class ClientForm
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
            this.lbIpC = new System.Windows.Forms.Label();
            this.lbPortC = new System.Windows.Forms.Label();
            this.tbxIpC = new System.Windows.Forms.TextBox();
            this.tbxPortC = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExitC = new System.Windows.Forms.Button();
            this.tbxChatHsC = new System.Windows.Forms.TextBox();
            this.tbxChatInputC = new System.Windows.Forms.TextBox();
            this.btnSendC = new System.Windows.Forms.Button();
            this.tbxnicname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbIpC
            // 
            this.lbIpC.AutoSize = true;
            this.lbIpC.Location = new System.Drawing.Point(15, 25);
            this.lbIpC.Name = "lbIpC";
            this.lbIpC.Size = new System.Drawing.Size(28, 12);
            this.lbIpC.TabIndex = 0;
            this.lbIpC.Text = "IP : ";
            // 
            // lbPortC
            // 
            this.lbPortC.AutoSize = true;
            this.lbPortC.Location = new System.Drawing.Point(12, 52);
            this.lbPortC.Name = "lbPortC";
            this.lbPortC.Size = new System.Drawing.Size(50, 12);
            this.lbPortC.TabIndex = 1;
            this.lbPortC.Text = "PORT : ";
            // 
            // tbxIpC
            // 
            this.tbxIpC.Location = new System.Drawing.Point(47, 16);
            this.tbxIpC.Name = "tbxIpC";
            this.tbxIpC.Size = new System.Drawing.Size(124, 21);
            this.tbxIpC.TabIndex = 2;
            // 
            // tbxPortC
            // 
            this.tbxPortC.CausesValidation = false;
            this.tbxPortC.Location = new System.Drawing.Point(68, 49);
            this.tbxPortC.Name = "tbxPortC";
            this.tbxPortC.Size = new System.Drawing.Size(103, 21);
            this.tbxPortC.TabIndex = 2;
            this.tbxPortC.TextChanged += new System.EventHandler(this.TbxPortC_TextChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(197, 10);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(70, 54);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "접속하기";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // btnExitC
            // 
            this.btnExitC.Location = new System.Drawing.Point(273, 10);
            this.btnExitC.Name = "btnExitC";
            this.btnExitC.Size = new System.Drawing.Size(70, 54);
            this.btnExitC.TabIndex = 3;
            this.btnExitC.Text = "나가기";
            this.btnExitC.UseVisualStyleBackColor = true;
            this.btnExitC.Click += new System.EventHandler(this.BtnExitC_Click);
            // 
            // tbxChatHsC
            // 
            this.tbxChatHsC.Location = new System.Drawing.Point(14, 125);
            this.tbxChatHsC.Multiline = true;
            this.tbxChatHsC.Name = "tbxChatHsC";
            this.tbxChatHsC.Size = new System.Drawing.Size(332, 299);
            this.tbxChatHsC.TabIndex = 4;
            // 
            // tbxChatInputC
            // 
            this.tbxChatInputC.Location = new System.Drawing.Point(14, 432);
            this.tbxChatInputC.Name = "tbxChatInputC";
            this.tbxChatInputC.Size = new System.Drawing.Size(255, 21);
            this.tbxChatInputC.TabIndex = 5;
            this.tbxChatInputC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxChatInputC_KeyUp);
            // 
            // btnSendC
            // 
            this.btnSendC.Location = new System.Drawing.Point(273, 430);
            this.btnSendC.Name = "btnSendC";
            this.btnSendC.Size = new System.Drawing.Size(75, 23);
            this.btnSendC.TabIndex = 6;
            this.btnSendC.Text = "보내기";
            this.btnSendC.UseVisualStyleBackColor = true;
            this.btnSendC.Click += new System.EventHandler(this.BtnSendC_Click);
            // 
            // tbxnicname
            // 
            this.tbxnicname.CausesValidation = false;
            this.tbxnicname.Location = new System.Drawing.Point(62, 84);
            this.tbxnicname.Name = "tbxnicname";
            this.tbxnicname.Size = new System.Drawing.Size(281, 21);
            this.tbxnicname.TabIndex = 2;
            this.tbxnicname.TextChanged += new System.EventHandler(this.TbxPortC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = " 닉네임 : ";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 465);
            this.Controls.Add(this.btnSendC);
            this.Controls.Add(this.tbxnicname);
            this.Controls.Add(this.tbxPortC);
            this.Controls.Add(this.tbxChatInputC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbIpC);
            this.Controls.Add(this.tbxChatHsC);
            this.Controls.Add(this.lbPortC);
            this.Controls.Add(this.btnExitC);
            this.Controls.Add(this.tbxIpC);
            this.Controls.Add(this.btnEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientForm";
            this.Text = "ClientChat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIpC;
        private System.Windows.Forms.Label lbPortC;
        private System.Windows.Forms.TextBox tbxIpC;
        private System.Windows.Forms.TextBox tbxPortC;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExitC;
        private System.Windows.Forms.TextBox tbxChatHsC;
        private System.Windows.Forms.TextBox tbxChatInputC;
        private System.Windows.Forms.Button btnSendC;
        private System.Windows.Forms.TextBox tbxnicname;
        private System.Windows.Forms.Label label1;
    }
}