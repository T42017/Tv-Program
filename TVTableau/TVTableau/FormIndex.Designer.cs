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
            this.PbxSVT1 = new System.Windows.Forms.PictureBox();
            this.LblSVT1CurrentDay = new System.Windows.Forms.Label();
            this.BtnPreviousDay = new System.Windows.Forms.Button();
            this.BtnNextDay = new System.Windows.Forms.Button();
            this.LbxProgrammes = new System.Windows.Forms.ListBox();
            this.TbxSelectedProgramme = new System.Windows.Forms.TextBox();
            this.BtnPreviousChannel = new System.Windows.Forms.Button();
            this.BtnNextChannel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSVT1)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxSVT1
            // 
            this.PbxSVT1.Image = global::TVTableau.Properties.Resources.svt1;
            this.PbxSVT1.InitialImage = global::TVTableau.Properties.Resources.svt1;
            this.PbxSVT1.Location = new System.Drawing.Point(195, 34);
            this.PbxSVT1.Name = "PbxSVT1";
            this.PbxSVT1.Size = new System.Drawing.Size(283, 153);
            this.PbxSVT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxSVT1.TabIndex = 1;
            this.PbxSVT1.TabStop = false;
            // 
            // LblSVT1CurrentDay
            // 
            this.LblSVT1CurrentDay.AutoSize = true;
            this.LblSVT1CurrentDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSVT1CurrentDay.Location = new System.Drawing.Point(382, 818);
            this.LblSVT1CurrentDay.Name = "LblSVT1CurrentDay";
            this.LblSVT1CurrentDay.Size = new System.Drawing.Size(169, 29);
            this.LblSVT1CurrentDay.TabIndex = 3;
            this.LblSVT1CurrentDay.Text = "den 23 augusti";
            // 
            // BtnPreviousDay
            // 
            this.BtnPreviousDay.Location = new System.Drawing.Point(301, 810);
            this.BtnPreviousDay.Name = "BtnPreviousDay";
            this.BtnPreviousDay.Size = new System.Drawing.Size(75, 51);
            this.BtnPreviousDay.TabIndex = 4;
            this.BtnPreviousDay.Text = "<";
            this.BtnPreviousDay.UseVisualStyleBackColor = true;
            this.BtnPreviousDay.Click += new System.EventHandler(this.BtnPreviousDay_Click);
            // 
            // BtnNextDay
            // 
            this.BtnNextDay.Location = new System.Drawing.Point(567, 810);
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
            this.LbxProgrammes.Location = new System.Drawing.Point(12, 237);
            this.LbxProgrammes.Name = "LbxProgrammes";
            this.LbxProgrammes.Size = new System.Drawing.Size(283, 624);
            this.LbxProgrammes.TabIndex = 6;
            this.LbxProgrammes.DoubleClick += new System.EventHandler(this.LbxProgrammes_DoubleClick);
            // 
            // TbxSelectedProgramme
            // 
            this.TbxSelectedProgramme.Location = new System.Drawing.Point(301, 237);
            this.TbxSelectedProgramme.Multiline = true;
            this.TbxSelectedProgramme.Name = "TbxSelectedProgramme";
            this.TbxSelectedProgramme.Size = new System.Drawing.Size(341, 567);
            this.TbxSelectedProgramme.TabIndex = 7;
            // 
            // BtnPreviousChannel
            // 
            this.BtnPreviousChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreviousChannel.Location = new System.Drawing.Point(122, 87);
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
            this.BtnNextChannel.Location = new System.Drawing.Point(484, 87);
            this.BtnNextChannel.Name = "BtnNextChannel";
            this.BtnNextChannel.Size = new System.Drawing.Size(67, 49);
            this.BtnNextChannel.TabIndex = 9;
            this.BtnNextChannel.Text = ">";
            this.BtnNextChannel.UseVisualStyleBackColor = true;
            this.BtnNextChannel.Click += new System.EventHandler(this.BtnNextChannel_Click);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 879);
            this.Controls.Add(this.BtnNextChannel);
            this.Controls.Add(this.BtnPreviousChannel);
            this.Controls.Add(this.TbxSelectedProgramme);
            this.Controls.Add(this.LbxProgrammes);
            this.Controls.Add(this.BtnNextDay);
            this.Controls.Add(this.BtnPreviousDay);
            this.Controls.Add(this.LblSVT1CurrentDay);
            this.Controls.Add(this.PbxSVT1);
            this.Name = "FormIndex";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbxSVT1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PbxSVT1;
        private System.Windows.Forms.Label LblSVT1CurrentDay;
        private System.Windows.Forms.Button BtnPreviousDay;
        private System.Windows.Forms.Button BtnNextDay;
        private System.Windows.Forms.ListBox LbxProgrammes;
        private System.Windows.Forms.TextBox TbxSelectedProgramme;
        private System.Windows.Forms.Button BtnPreviousChannel;
        private System.Windows.Forms.Button BtnNextChannel;
    }
}

