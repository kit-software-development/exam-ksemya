﻿namespace MyChatRoomClient
{
    partial class FChatRoomClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChatRoomClient));
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.txtMsgSend = new System.Windows.Forms.TextBox();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(541, 39);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(87, 44);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(325, 42);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(116, 30);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "50001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(113, 42);
            this.txtIP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(116, 30);
            this.txtIP.TabIndex = 6;
            this.txtIP.Text = "192.168.0.103";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP:";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(113, 131);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(515, 400);
            this.txtMsg.TabIndex = 8;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(541, 582);
            this.btnSendMsg.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(112, 44);
            this.btnSendMsg.TabIndex = 10;
            this.btnSendMsg.Text = "Send message";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // txtMsgSend
            // 
            this.txtMsgSend.Location = new System.Drawing.Point(113, 582);
            this.txtMsgSend.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMsgSend.Name = "txtMsgSend";
            this.txtMsgSend.Size = new System.Drawing.Size(390, 30);
            this.txtMsgSend.TabIndex = 9;
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(541, 639);
            this.btnSendFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(87, 44);
            this.btnSendFile.TabIndex = 12;
            this.btnSendFile.Text = "Send file";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.White;
            this.txtFilePath.Location = new System.Drawing.Point(113, 647);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(312, 30);
            this.txtFilePath.TabIndex = 11;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(448, 639);
            this.btnChooseFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(87, 44);
            this.btnChooseFile.TabIndex = 13;
            this.btnChooseFile.Text = "Selct a file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // FChatRoomClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(730, 749);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.txtMsgSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Mark My Words", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FChatRoomClient";
            this.Text = "Chat Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox txtMsgSend;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnChooseFile;
    }
}

