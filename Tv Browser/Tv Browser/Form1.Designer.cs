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
            this.titlebox = new System.Windows.Forms.TextBox();
            this.dayChooser = new System.Windows.Forms.ListBox();
            this.previousTime = new System.Windows.Forms.Button();
            this.nextTime = new System.Windows.Forms.Button();
            this.airingTime = new System.Windows.Forms.TextBox();
            this.subTitleBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.episodeNumberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "travelchanneltv.se"});
            this.listBox1.Location = new System.Drawing.Point(12, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(109, 615);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.tvChannelList_SelectedIndexChanged);
            // 
            // titlebox
            // 
            this.titlebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlebox.Location = new System.Drawing.Point(253, 11);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(592, 38);
            this.titlebox.TabIndex = 1;
            this.titlebox.TextChanged += new System.EventHandler(this.titlebox_TextChanged);
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
            this.airingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airingTime.Location = new System.Drawing.Point(932, 12);
            this.airingTime.Name = "airingTime";
            this.airingTime.Size = new System.Drawing.Size(324, 38);
            this.airingTime.TabIndex = 5;
            this.airingTime.TextChanged += new System.EventHandler(this.airingTime_TextChanged);
            // 
            // subTitleBox
            // 
            this.subTitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitleBox.Location = new System.Drawing.Point(253, 56);
            this.subTitleBox.Name = "subTitleBox";
            this.subTitleBox.Size = new System.Drawing.Size(592, 30);
            this.subTitleBox.TabIndex = 6;
            this.subTitleBox.TextChanged += new System.EventHandler(this.subTitleBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(253, 130);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(592, 393);
            this.descriptionTextBox.TabIndex = 7;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // episodeNumberBox
            // 
            this.episodeNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.episodeNumberBox.Location = new System.Drawing.Point(582, 94);
            this.episodeNumberBox.Name = "episodeNumberBox";
            this.episodeNumberBox.Size = new System.Drawing.Size(263, 30);
            this.episodeNumberBox.TabIndex = 8;
            this.episodeNumberBox.TextChanged += new System.EventHandler(this.episodeNumberBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 638);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.episodeNumberBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.subTitleBox);
            this.Controls.Add(this.airingTime);
            this.Controls.Add(this.nextTime);
            this.Controls.Add(this.previousTime);
            this.Controls.Add(this.dayChooser);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.ListBox dayChooser;
        private System.Windows.Forms.Button previousTime;
        private System.Windows.Forms.Button nextTime;
        private System.Windows.Forms.TextBox airingTime;
        private System.Windows.Forms.TextBox subTitleBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox episodeNumberBox;
        private System.Windows.Forms.Label label1;
    }
}

