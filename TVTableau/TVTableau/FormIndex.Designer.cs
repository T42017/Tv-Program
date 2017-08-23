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
            this.BtnShowNext = new System.Windows.Forms.Button();
            this.PbxSVT1 = new System.Windows.Forms.PictureBox();
            this.RtbxSVT1Programmes = new System.Windows.Forms.RichTextBox();
            this.LblSVT1CurrentDay = new System.Windows.Forms.Label();
            this.BtnSVT1PreviousDay = new System.Windows.Forms.Button();
            this.BtnSVT1NextDay = new System.Windows.Forms.Button();
            this.LbxSVT1Programmes = new System.Windows.Forms.ListBox();
            this.TbxSVT1SelectedProgramme = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSVT1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnShowNext
            // 
            this.BtnShowNext.Location = new System.Drawing.Point(760, 39);
            this.BtnShowNext.Name = "BtnShowNext";
            this.BtnShowNext.Size = new System.Drawing.Size(196, 95);
            this.BtnShowNext.TabIndex = 0;
            this.BtnShowNext.Text = "Show next programme";
            this.BtnShowNext.UseVisualStyleBackColor = true;
            this.BtnShowNext.Click += new System.EventHandler(this.BtnShowNext_Click);
            // 
            // PbxSVT1
            // 
            this.PbxSVT1.Image = global::TVTableau.Properties.Resources.svt1;
            this.PbxSVT1.InitialImage = global::TVTableau.Properties.Resources.svt1;
            this.PbxSVT1.Location = new System.Drawing.Point(12, 12);
            this.PbxSVT1.Name = "PbxSVT1";
            this.PbxSVT1.Size = new System.Drawing.Size(283, 153);
            this.PbxSVT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxSVT1.TabIndex = 1;
            this.PbxSVT1.TabStop = false;
            // 
            // RtbxSVT1Programmes
            // 
            this.RtbxSVT1Programmes.Location = new System.Drawing.Point(1053, 39);
            this.RtbxSVT1Programmes.Name = "RtbxSVT1Programmes";
            this.RtbxSVT1Programmes.Size = new System.Drawing.Size(88, 101);
            this.RtbxSVT1Programmes.TabIndex = 2;
            this.RtbxSVT1Programmes.Text = "";
            // 
            // LblSVT1CurrentDay
            // 
            this.LblSVT1CurrentDay.AutoSize = true;
            this.LblSVT1CurrentDay.Location = new System.Drawing.Point(100, 191);
            this.LblSVT1CurrentDay.Name = "LblSVT1CurrentDay";
            this.LblSVT1CurrentDay.Size = new System.Drawing.Size(114, 20);
            this.LblSVT1CurrentDay.TabIndex = 3;
            this.LblSVT1CurrentDay.Text = "den 23 augusti";
            // 
            // BtnSVT1PreviousDay
            // 
            this.BtnSVT1PreviousDay.Location = new System.Drawing.Point(12, 176);
            this.BtnSVT1PreviousDay.Name = "BtnSVT1PreviousDay";
            this.BtnSVT1PreviousDay.Size = new System.Drawing.Size(75, 51);
            this.BtnSVT1PreviousDay.TabIndex = 4;
            this.BtnSVT1PreviousDay.Text = "<";
            this.BtnSVT1PreviousDay.UseVisualStyleBackColor = true;
            this.BtnSVT1PreviousDay.Click += new System.EventHandler(this.BtnSVT1PreviousDay_Click);
            // 
            // BtnSVT1NextDay
            // 
            this.BtnSVT1NextDay.Location = new System.Drawing.Point(220, 176);
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
            this.LbxSVT1Programmes.Size = new System.Drawing.Size(283, 944);
            this.LbxSVT1Programmes.TabIndex = 6;
            this.LbxSVT1Programmes.DoubleClick += new System.EventHandler(this.LbxSVT1Programmes_DoubleClick);
            // 
            // TbxSVT1SelectedProgramme
            // 
            this.TbxSVT1SelectedProgramme.Location = new System.Drawing.Point(301, 237);
            this.TbxSVT1SelectedProgramme.Multiline = true;
            this.TbxSVT1SelectedProgramme.Name = "TbxSVT1SelectedProgramme";
            this.TbxSVT1SelectedProgramme.Size = new System.Drawing.Size(387, 447);
            this.TbxSVT1SelectedProgramme.TabIndex = 7;
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 1193);
            this.Controls.Add(this.TbxSVT1SelectedProgramme);
            this.Controls.Add(this.LbxSVT1Programmes);
            this.Controls.Add(this.BtnSVT1NextDay);
            this.Controls.Add(this.BtnSVT1PreviousDay);
            this.Controls.Add(this.LblSVT1CurrentDay);
            this.Controls.Add(this.RtbxSVT1Programmes);
            this.Controls.Add(this.PbxSVT1);
            this.Controls.Add(this.BtnShowNext);
            this.Name = "FormIndex";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbxSVT1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShowNext;
        private System.Windows.Forms.PictureBox PbxSVT1;
        private System.Windows.Forms.RichTextBox RtbxSVT1Programmes;
        private System.Windows.Forms.Label LblSVT1CurrentDay;
        private System.Windows.Forms.Button BtnSVT1PreviousDay;
        private System.Windows.Forms.Button BtnSVT1NextDay;
        private System.Windows.Forms.ListBox LbxSVT1Programmes;
        private System.Windows.Forms.TextBox TbxSVT1SelectedProgramme;
    }
}

