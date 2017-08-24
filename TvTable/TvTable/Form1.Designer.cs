﻿namespace TvTable
{
    partial class Form1
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
            this.ChannelList = new System.Windows.Forms.ListBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.channelTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgramList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DetailsTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChannelList
            // 
            this.ChannelList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ChannelList.FormattingEnabled = true;
            this.ChannelList.ItemHeight = 20;
            this.ChannelList.Location = new System.Drawing.Point(12, 71);
            this.ChannelList.Margin = new System.Windows.Forms.Padding(3, 1, 10, 1);
            this.ChannelList.Name = "ChannelList";
            this.ChannelList.Size = new System.Drawing.Size(587, 1104);
            this.ChannelList.TabIndex = 0;
            this.ChannelList.SelectedIndexChanged += new System.EventHandler(this.ChannelList_SelectedIndexChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(612, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 46);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // channelTbx
            // 
            this.channelTbx.Location = new System.Drawing.Point(12, 32);
            this.channelTbx.Name = "channelTbx";
            this.channelTbx.Size = new System.Drawing.Size(368, 26);
            this.channelTbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Channel name";
            // 
            // ProgramList
            // 
            this.ProgramList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgramList.FormattingEnabled = true;
            this.ProgramList.ItemHeight = 20;
            this.ProgramList.Location = new System.Drawing.Point(612, 71);
            this.ProgramList.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ProgramList.Name = "ProgramList";
            this.ProgramList.Size = new System.Drawing.Size(587, 1104);
            this.ProgramList.TabIndex = 4;
            this.ProgramList.SelectedIndexChanged += new System.EventHandler(this.ProgramList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(971, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "-->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(756, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "<--";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(854, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Change day";
            // 
            // DetailsTbx
            // 
            this.DetailsTbx.Location = new System.Drawing.Point(1212, 71);
            this.DetailsTbx.Multiline = true;
            this.DetailsTbx.Name = "DetailsTbx";
            this.DetailsTbx.Size = new System.Drawing.Size(586, 1102);
            this.DetailsTbx.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 1185);
            this.Controls.Add(this.DetailsTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProgramList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.channelTbx);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.ChannelList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ChannelList;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox channelTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ProgramList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DetailsTbx;
    }
}

