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
            this.BtnSVT1PreviousDay = new System.Windows.Forms.Button();
            this.BtnSVT1NextDay = new System.Windows.Forms.Button();
            this.LbxSVT1Programmes = new System.Windows.Forms.ListBox();
            this.TbxSVT1SelectedProgramme = new System.Windows.Forms.TextBox();
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
            // BtnSVT1PreviousDay
            // 
            this.BtnSVT1PreviousDay.Location = new System.Drawing.Point(301, 810);
            this.BtnSVT1PreviousDay.Name = "BtnSVT1PreviousDay";
            this.BtnSVT1PreviousDay.Size = new System.Drawing.Size(75, 51);
            this.BtnSVT1PreviousDay.TabIndex = 4;
            this.BtnSVT1PreviousDay.Text = "<";
            this.BtnSVT1PreviousDay.UseVisualStyleBackColor = true;
            this.BtnSVT1PreviousDay.Click += new System.EventHandler(this.BtnSVT1PreviousDay_Click);
            // 
            // BtnSVT1NextDay
            // 
            this.BtnSVT1NextDay.Location = new System.Drawing.Point(567, 810);
            this.BtnSVT1NextDay.Name = "BtnSVT1NextDay";
            this.BtnSVT1NextDay.Size = new System.Drawing.Size(75, 51);
            this.BtnSVT1NextDay.TabIndex = 5;
            this.BtnSVT1NextDay.Text = ">";
            this.BtnSVT1NextDay.UseVisualStyleBackColor = true;
            this.BtnSVT1NextDay.Click += new System.EventHandler(this.BtnSVT1NextDay_Click);
            // 
            // LbxSVT1Programmes
            // 
            this.LbxSVT1Programmes.FormattingEnabled = true;
            this.LbxSVT1Programmes.ItemHeight = 20;
            this.LbxSVT1Programmes.Location = new System.Drawing.Point(12, 237);
            this.LbxSVT1Programmes.Name = "LbxSVT1Programmes";
            this.LbxSVT1Programmes.Size = new System.Drawing.Size(283, 624);
            this.LbxSVT1Programmes.TabIndex = 6;
            this.LbxSVT1Programmes.DoubleClick += new System.EventHandler(this.LbxSVT1Programmes_DoubleClick);
            // 
            // TbxSVT1SelectedProgramme
            // 
            this.TbxSVT1SelectedProgramme.Location = new System.Drawing.Point(301, 237);
            this.TbxSVT1SelectedProgramme.Multiline = true;
            this.TbxSVT1SelectedProgramme.Name = "TbxSVT1SelectedProgramme";
            this.TbxSVT1SelectedProgramme.Size = new System.Drawing.Size(341, 567);
            this.TbxSVT1SelectedProgramme.TabIndex = 7;
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
            this.Controls.Add(this.TbxSVT1SelectedProgramme);
            this.Controls.Add(this.LbxSVT1Programmes);
            this.Controls.Add(this.BtnSVT1NextDay);
            this.Controls.Add(this.BtnSVT1PreviousDay);
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
        private System.Windows.Forms.Button BtnSVT1PreviousDay;
        private System.Windows.Forms.Button BtnSVT1NextDay;
        private System.Windows.Forms.ListBox LbxSVT1Programmes;
        private System.Windows.Forms.TextBox TbxSVT1SelectedProgramme;
        private System.Windows.Forms.Button BtnPreviousChannel;
        private System.Windows.Forms.Button BtnNextChannel;
    }
}

