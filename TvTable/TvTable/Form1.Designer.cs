namespace TvTable
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
            this.SuspendLayout();
            // 
            // ChannelList
            // 
            this.ChannelList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChannelList.FormattingEnabled = true;
            this.ChannelList.ItemHeight = 20;
            this.ChannelList.Location = new System.Drawing.Point(12, 71);
            this.ChannelList.Margin = new System.Windows.Forms.Padding(1);
            this.ChannelList.Name = "ChannelList";
            this.ChannelList.Size = new System.Drawing.Size(405, 1104);
            this.ChannelList.TabIndex = 0;
            this.ChannelList.SelectedIndexChanged += new System.EventHandler(this.ChannelList_SelectedIndexChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(478, 12);
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
            this.channelTbx.Size = new System.Drawing.Size(405, 26);
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
            this.ProgramList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgramList.FormattingEnabled = true;
            this.ProgramList.ItemHeight = 20;
            this.ProgramList.Location = new System.Drawing.Point(478, 71);
            this.ProgramList.Margin = new System.Windows.Forms.Padding(1);
            this.ProgramList.Name = "ProgramList";
            this.ProgramList.Size = new System.Drawing.Size(491, 1104);
            this.ProgramList.TabIndex = 0;
            this.ProgramList.SelectedIndexChanged += new System.EventHandler(this.ChannelList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 1185);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.channelTbx);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.ProgramList);
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
    }
}

