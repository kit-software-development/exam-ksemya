namespace MyChatRoomServer
{
    partial class FChatServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChatServer));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnBeginListen = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtMsgSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOnline = new System.Windows.Forms.ListBox();
            this.btnSendToAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(85, 38);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 28);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "192.168.0.103";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(266, 38);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 28);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "50001";
            // 
            // btnBeginListen
            // 
            this.btnBeginListen.Location = new System.Drawing.Point(451, 30);
            this.btnBeginListen.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.btnBeginListen.Name = "btnBeginListen";
            this.btnBeginListen.Size = new System.Drawing.Size(74, 41);
            this.btnBeginListen.TabIndex = 2;
            this.btnBeginListen.Text = "Open";
            this.btnBeginListen.UseVisualStyleBackColor = true;
            this.btnBeginListen.Click += new System.EventHandler(this.btnBeginListen_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(182, 140);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(345, 316);
            this.txtMsg.TabIndex = 3;
            // 
            // txtMsgSend
            // 
            this.txtMsgSend.Location = new System.Drawing.Point(182, 490);
            this.txtMsgSend.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.txtMsgSend.Name = "txtMsgSend";
            this.txtMsgSend.Size = new System.Drawing.Size(345, 28);
            this.txtMsgSend.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(451, 547);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(74, 41);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Online list:";
            // 
            // lbOnline
            // 
            this.lbOnline.FormattingEnabled = true;
            this.lbOnline.ItemHeight = 22;
            this.lbOnline.Location = new System.Drawing.Point(29, 140);
            this.lbOnline.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.lbOnline.Name = "lbOnline";
            this.lbOnline.Size = new System.Drawing.Size(130, 378);
            this.lbOnline.TabIndex = 7;
            // 
            // btnSendToAll
            // 
            this.btnSendToAll.Location = new System.Drawing.Point(440, 611);
            this.btnSendToAll.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.btnSendToAll.Name = "btnSendToAll";
            this.btnSendToAll.Size = new System.Drawing.Size(85, 41);
            this.btnSendToAll.TabIndex = 5;
            this.btnSendToAll.Text = "Mass mesage";
            this.btnSendToAll.UseVisualStyleBackColor = true;
            this.btnSendToAll.Click += new System.EventHandler(this.btnSendToAll_Click);
            // 
            // FChatServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(589, 686);
            this.Controls.Add(this.lbOnline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSendToAll);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsgSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnBeginListen);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Mark My Words", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.Name = "FChatServer";
            this.Text = "Chat Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnBeginListen;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtMsgSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbOnline;
        private System.Windows.Forms.Button btnSendToAll;
    }
}

