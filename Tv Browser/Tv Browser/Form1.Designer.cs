namespace Tv_Browser
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dayChooser = new System.Windows.Forms.ListBox();
            this.previousTime = new System.Windows.Forms.Button();
            this.nextTime = new System.Windows.Forms.Button();
            this.airingTime = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.episodeNumberLabel = new System.Windows.Forms.Label();
            this.currentlyOnAirLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nextOnAirLink = new System.Windows.Forms.LinkLabel();
            this.timer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "travelchanneltv.se",
            "comedycentral.tv"});
            this.listBox1.Location = new System.Drawing.Point(12, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(109, 615);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.tvChannelList_SelectedIndexChanged);
            // 
            // dayChooser
            // 
            this.dayChooser.FormattingEnabled = true;
            this.dayChooser.Location = new System.Drawing.Point(127, 11);
            this.dayChooser.Name = "dayChooser";
            this.dayChooser.Size = new System.Drawing.Size(120, 615);
            this.dayChooser.TabIndex = 2;
            this.dayChooser.SelectedIndexChanged += new System.EventHandler(this.dayChooser_SelectedIndexChanged);
            // 
            // previousTime
            // 
            this.previousTime.Location = new System.Drawing.Point(887, 12);
            this.previousTime.Name = "previousTime";
            this.previousTime.Size = new System.Drawing.Size(39, 39);
            this.previousTime.TabIndex = 3;
            this.previousTime.Text = "<-";
            this.previousTime.UseVisualStyleBackColor = true;
            this.previousTime.Click += new System.EventHandler(this.previousTime_Click);
            // 
            // nextTime
            // 
            this.nextTime.Location = new System.Drawing.Point(1262, 12);
            this.nextTime.Name = "nextTime";
            this.nextTime.Size = new System.Drawing.Size(39, 39);
            this.nextTime.TabIndex = 4;
            this.nextTime.Text = "->";
            this.nextTime.UseVisualStyleBackColor = true;
            this.nextTime.Click += new System.EventHandler(this.nextTime_Click);
            // 
            // airingTime
            // 
            this.airingTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.airingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airingTime.Location = new System.Drawing.Point(932, 17);
            this.airingTime.Name = "airingTime";
            this.airingTime.Size = new System.Drawing.Size(324, 31);
            this.airingTime.TabIndex = 5;
            this.airingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.airingTime.TextChanged += new System.EventHandler(this.airingTime_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(253, 163);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(592, 463);
            this.descriptionTextBox.TabIndex = 7;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(253, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(109, 39);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "label1";
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.AutoSize = true;
            this.subTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleLabel.Location = new System.Drawing.Point(253, 58);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(115, 25);
            this.subTitleLabel.TabIndex = 10;
            this.subTitleLabel.Text = "episode title";
            this.subTitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // episodeNumberLabel
            // 
            this.episodeNumberLabel.AutoSize = true;
            this.episodeNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeNumberLabel.Location = new System.Drawing.Point(661, 102);
            this.episodeNumberLabel.Name = "episodeNumberLabel";
            this.episodeNumberLabel.Size = new System.Drawing.Size(184, 25);
            this.episodeNumberLabel.TabIndex = 11;
            this.episodeNumberLabel.Text = "Episode 6 season 3";
            // 
            // currentlyOnAirLink
            // 
            this.currentlyOnAirLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentlyOnAirLink.Location = new System.Drawing.Point(956, 293);
            this.currentlyOnAirLink.Name = "currentlyOnAirLink";
            this.currentlyOnAirLink.Size = new System.Drawing.Size(300, 29);
            this.currentlyOnAirLink.TabIndex = 12;
            this.currentlyOnAirLink.TabStop = true;
            this.currentlyOnAirLink.Text = "Loading...";
            this.currentlyOnAirLink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.currentlyOnAirLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.currentlyOnAirLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(998, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Currently On Air:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(967, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Next On Air In:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nextOnAirLink
            // 
            this.nextOnAirLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextOnAirLink.Location = new System.Drawing.Point(956, 454);
            this.nextOnAirLink.Name = "nextOnAirLink";
            this.nextOnAirLink.Size = new System.Drawing.Size(300, 33);
            this.nextOnAirLink.TabIndex = 15;
            this.nextOnAirLink.TabStop = true;
            this.nextOnAirLink.Text = "Loading...";
            this.nextOnAirLink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(1164, 390);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(82, 31);
            this.timer.TabIndex = 16;
            this.timer.Text = "00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 638);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.nextOnAirLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentlyOnAirLink);
            this.Controls.Add(this.episodeNumberLabel);
            this.Controls.Add(this.subTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.airingTime);
            this.Controls.Add(this.nextTime);
            this.Controls.Add(this.previousTime);
            this.Controls.Add(this.dayChooser);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox dayChooser;
        private System.Windows.Forms.Button previousTime;
        private System.Windows.Forms.Button nextTime;
        private System.Windows.Forms.TextBox airingTime;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subTitleLabel;
        private System.Windows.Forms.Label episodeNumberLabel;
        private System.Windows.Forms.LinkLabel currentlyOnAirLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel nextOnAirLink;
        private System.Windows.Forms.Label timer;
    }
}

