namespace TVTableau
{
    partial class FormIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndex));
            this.PbxCurrentChannel = new System.Windows.Forms.PictureBox();
            this.LblCurrentDay = new System.Windows.Forms.Label();
            this.BtnPreviousDay = new System.Windows.Forms.Button();
            this.BtnNextDay = new System.Windows.Forms.Button();
            this.LbxProgrammes = new System.Windows.Forms.ListBox();
            this.TbxSelectedProgramme = new System.Windows.Forms.TextBox();
            this.BtnPreviousChannel = new System.Windows.Forms.Button();
            this.BtnNextChannel = new System.Windows.Forms.Button();
            this.PbxTv6 = new System.Windows.Forms.PictureBox();
            this.PbxKanal5 = new System.Windows.Forms.PictureBox();
            this.PbxTv4 = new System.Windows.Forms.PictureBox();
            this.PbxTv3 = new System.Windows.Forms.PictureBox();
            this.PbxSvt2 = new System.Windows.Forms.PictureBox();
            this.PbxSvt1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCurrentChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTv6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxKanal5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSvt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSvt1)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxCurrentChannel
            // 
            this.PbxCurrentChannel.Image = global::TVTableau.Properties.Resources.svt1;
            this.PbxCurrentChannel.InitialImage = global::TVTableau.Properties.Resources.svt1;
            this.PbxCurrentChannel.Location = new System.Drawing.Point(229, 128);
            this.PbxCurrentChannel.Name = "PbxCurrentChannel";
            this.PbxCurrentChannel.Size = new System.Drawing.Size(283, 153);
            this.PbxCurrentChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxCurrentChannel.TabIndex = 1;
            this.PbxCurrentChannel.TabStop = false;
            // 
            // LblCurrentDay
            // 
            this.LblCurrentDay.AutoSize = true;
            this.LblCurrentDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrentDay.Location = new System.Drawing.Point(472, 897);
            this.LblCurrentDay.Name = "LblCurrentDay";
            this.LblCurrentDay.Size = new System.Drawing.Size(0, 25);
            this.LblCurrentDay.TabIndex = 3;
            // 
            // BtnPreviousDay
            // 
            this.BtnPreviousDay.Location = new System.Drawing.Point(381, 886);
            this.BtnPreviousDay.Name = "BtnPreviousDay";
            this.BtnPreviousDay.Size = new System.Drawing.Size(75, 51);
            this.BtnPreviousDay.TabIndex = 4;
            this.BtnPreviousDay.Text = "<";
            this.BtnPreviousDay.UseVisualStyleBackColor = true;
            this.BtnPreviousDay.Click += new System.EventHandler(this.BtnPreviousDay_Click);
            // 
            // BtnNextDay
            // 
            this.BtnNextDay.Location = new System.Drawing.Point(647, 886);
            this.BtnNextDay.Name = "BtnNextDay";
            this.BtnNextDay.Size = new System.Drawing.Size(75, 51);
            this.BtnNextDay.TabIndex = 5;
            this.BtnNextDay.Text = ">";
            this.BtnNextDay.UseVisualStyleBackColor = true;
            this.BtnNextDay.Click += new System.EventHandler(this.BtnNextDay_Click);
            // 
            // LbxProgrammes
            // 
            this.LbxProgrammes.FormattingEnabled = true;
            this.LbxProgrammes.ItemHeight = 20;
            this.LbxProgrammes.Location = new System.Drawing.Point(12, 313);
            this.LbxProgrammes.Name = "LbxProgrammes";
            this.LbxProgrammes.Size = new System.Drawing.Size(363, 624);
            this.LbxProgrammes.TabIndex = 6;
            this.LbxProgrammes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LbxProgrammes_DrawItem);
            this.LbxProgrammes.DoubleClick += new System.EventHandler(this.LbxProgrammes_DoubleClick);
            // 
            // TbxSelectedProgramme
            // 
            this.TbxSelectedProgramme.Location = new System.Drawing.Point(381, 313);
            this.TbxSelectedProgramme.Multiline = true;
            this.TbxSelectedProgramme.Name = "TbxSelectedProgramme";
            this.TbxSelectedProgramme.ReadOnly = true;
            this.TbxSelectedProgramme.Size = new System.Drawing.Size(341, 567);
            this.TbxSelectedProgramme.TabIndex = 7;
            // 
            // BtnPreviousChannel
            // 
            this.BtnPreviousChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreviousChannel.Location = new System.Drawing.Point(156, 182);
            this.BtnPreviousChannel.Name = "BtnPreviousChannel";
            this.BtnPreviousChannel.Size = new System.Drawing.Size(67, 49);
            this.BtnPreviousChannel.TabIndex = 8;
            this.BtnPreviousChannel.Text = "<";
            this.BtnPreviousChannel.UseVisualStyleBackColor = true;
            this.BtnPreviousChannel.Click += new System.EventHandler(this.BtnPreviousChannel_Click);
            // 
            // BtnNextChannel
            // 
            this.BtnNextChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextChannel.Location = new System.Drawing.Point(518, 182);
            this.BtnNextChannel.Name = "BtnNextChannel";
            this.BtnNextChannel.Size = new System.Drawing.Size(67, 49);
            this.BtnNextChannel.TabIndex = 9;
            this.BtnNextChannel.Text = ">";
            this.BtnNextChannel.UseVisualStyleBackColor = true;
            this.BtnNextChannel.Click += new System.EventHandler(this.BtnNextChannel_Click);
            // 
            // PbxTv6
            // 
            this.PbxTv6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxTv6.Image = ((System.Drawing.Image)(resources.GetObject("PbxTv6.Image")));
            this.PbxTv6.Location = new System.Drawing.Point(647, 12);
            this.PbxTv6.Name = "PbxTv6";
            this.PbxTv6.Size = new System.Drawing.Size(72, 69);
            this.PbxTv6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxTv6.TabIndex = 10;
            this.PbxTv6.TabStop = false;
            this.PbxTv6.Click += new System.EventHandler(this.PbxSwitchChannel_Click);
            // 
            // PbxKanal5
            // 
            this.PbxKanal5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxKanal5.Image = ((System.Drawing.Image)(resources.GetObject("PbxKanal5.Image")));
            this.PbxKanal5.Location = new System.Drawing.Point(513, 12);
            this.PbxKanal5.Name = "PbxKanal5";
            this.PbxKanal5.Size = new System.Drawing.Size(72, 69);
            this.PbxKanal5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxKanal5.TabIndex = 11;
            this.PbxKanal5.TabStop = false;
            this.PbxKanal5.Click += new System.EventHandler(this.PbxSwitchChannel_Click);
            // 
            // PbxTv4
            // 
            this.PbxTv4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxTv4.Image = ((System.Drawing.Image)(resources.GetObject("PbxTv4.Image")));
            this.PbxTv4.Location = new System.Drawing.Point(381, 12);
            this.PbxTv4.Name = "PbxTv4";
            this.PbxTv4.Size = new System.Drawing.Size(72, 69);
            this.PbxTv4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxTv4.TabIndex = 12;
            this.PbxTv4.TabStop = false;
            this.PbxTv4.Click += new System.EventHandler(this.PbxSwitchChannel_Click);
            // 
            // PbxTv3
            // 
            this.PbxTv3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxTv3.Image = ((System.Drawing.Image)(resources.GetObject("PbxTv3.Image")));
            this.PbxTv3.Location = new System.Drawing.Point(250, 12);
            this.PbxTv3.Name = "PbxTv3";
            this.PbxTv3.Size = new System.Drawing.Size(72, 69);
            this.PbxTv3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxTv3.TabIndex = 13;
            this.PbxTv3.TabStop = false;
            this.PbxTv3.Click += new System.EventHandler(this.PbxSwitchChannel_Click);
            // 
            // PbxSvt2
            // 
            this.PbxSvt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxSvt2.Image = ((System.Drawing.Image)(resources.GetObject("PbxSvt2.Image")));
            this.PbxSvt2.Location = new System.Drawing.Point(132, 12);
            this.PbxSvt2.Name = "PbxSvt2";
            this.PbxSvt2.Size = new System.Drawing.Size(72, 69);
            this.PbxSvt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxSvt2.TabIndex = 14;
            this.PbxSvt2.TabStop = false;
            this.PbxSvt2.Click += new System.EventHandler(this.PbxSwitchChannel_Click);
            // 
            // PbxSvt1
            // 
            this.PbxSvt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxSvt1.Image = ((System.Drawing.Image)(resources.GetObject("PbxSvt1.Image")));
            this.PbxSvt1.Location = new System.Drawing.Point(12, 12);
            this.PbxSvt1.Name = "PbxSvt1";
            this.PbxSvt1.Size = new System.Drawing.Size(72, 69);
            this.PbxSvt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxSvt1.TabIndex = 15;
            this.PbxSvt1.TabStop = false;
            this.PbxSvt1.Click += new System.EventHandler(this.PbxSwitchChannel_Click);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 949);
            this.Controls.Add(this.PbxSvt1);
            this.Controls.Add(this.PbxSvt2);
            this.Controls.Add(this.PbxTv3);
            this.Controls.Add(this.PbxTv4);
            this.Controls.Add(this.PbxKanal5);
            this.Controls.Add(this.PbxTv6);
            this.Controls.Add(this.BtnNextChannel);
            this.Controls.Add(this.BtnPreviousChannel);
            this.Controls.Add(this.TbxSelectedProgramme);
            this.Controls.Add(this.LbxProgrammes);
            this.Controls.Add(this.BtnNextDay);
            this.Controls.Add(this.BtnPreviousDay);
            this.Controls.Add(this.LblCurrentDay);
            this.Controls.Add(this.PbxCurrentChannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormIndex";
            this.Text = "TV tableau";
            ((System.ComponentModel.ISupportInitialize)(this.PbxCurrentChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTv6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxKanal5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxTv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSvt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSvt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PbxCurrentChannel;
        private System.Windows.Forms.Label LblCurrentDay;
        private System.Windows.Forms.Button BtnPreviousDay;
        private System.Windows.Forms.Button BtnNextDay;
        private System.Windows.Forms.ListBox LbxProgrammes;
        private System.Windows.Forms.TextBox TbxSelectedProgramme;
        private System.Windows.Forms.Button BtnPreviousChannel;
        private System.Windows.Forms.Button BtnNextChannel;
        private System.Windows.Forms.PictureBox PbxTv6;
        private System.Windows.Forms.PictureBox PbxKanal5;
        private System.Windows.Forms.PictureBox PbxTv4;
        private System.Windows.Forms.PictureBox PbxTv3;
        private System.Windows.Forms.PictureBox PbxSvt2;
        private System.Windows.Forms.PictureBox PbxSvt1;
    }
}

