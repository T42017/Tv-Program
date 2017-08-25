namespace tvprog
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
            this.btnDaybwd = new System.Windows.Forms.Button();
            this.btnCurdate = new System.Windows.Forms.Button();
            this.btnDayfwd = new System.Windows.Forms.Button();
            this.tbxDateTime = new System.Windows.Forms.TextBox();
            this.lboxTitles = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDaybwd
            // 
            this.btnDaybwd.AutoSize = true;
            this.btnDaybwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaybwd.Location = new System.Drawing.Point(327, 618);
            this.btnDaybwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDaybwd.Name = "btnDaybwd";
            this.btnDaybwd.Size = new System.Drawing.Size(126, 27);
            this.btnDaybwd.TabIndex = 0;
            this.btnDaybwd.Text = "Go back one day";
            this.btnDaybwd.UseVisualStyleBackColor = true;
            this.btnDaybwd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCurdate
            // 
            this.btnCurdate.AutoSize = true;
            this.btnCurdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurdate.Location = new System.Drawing.Point(473, 618);
            this.btnCurdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCurdate.Name = "btnCurdate";
            this.btnCurdate.Size = new System.Drawing.Size(134, 27);
            this.btnCurdate.TabIndex = 1;
            this.btnCurdate.Text = "Go to current date";
            this.btnCurdate.UseVisualStyleBackColor = true;
            this.btnCurdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDayfwd
            // 
            this.btnDayfwd.AutoSize = true;
            this.btnDayfwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDayfwd.Location = new System.Drawing.Point(620, 618);
            this.btnDayfwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDayfwd.Name = "btnDayfwd";
            this.btnDayfwd.Size = new System.Drawing.Size(143, 27);
            this.btnDayfwd.TabIndex = 2;
            this.btnDayfwd.Text = "Go one day forward";
            this.btnDayfwd.UseVisualStyleBackColor = true;
            this.btnDayfwd.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbxDateTime
            // 
            this.tbxDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDateTime.Location = new System.Drawing.Point(428, 34);
            this.tbxDateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxDateTime.Name = "tbxDateTime";
            this.tbxDateTime.ReadOnly = true;
            this.tbxDateTime.Size = new System.Drawing.Size(216, 28);
            this.tbxDateTime.TabIndex = 4;
            this.tbxDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lboxTitles
            // 
            this.lboxTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxTitles.FormattingEnabled = true;
            this.lboxTitles.ItemHeight = 17;
            this.lboxTitles.Location = new System.Drawing.Point(271, 89);
            this.lboxTitles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lboxTitles.Name = "lboxTitles";
            this.lboxTitles.Size = new System.Drawing.Size(529, 497);
            this.lboxTitles.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SVT 1",
            "SVT 2",
            "TV3",
            "TV4",
            "Kanal 5",
            "TV6",
            "TV3 Sport",
            "Viasat Fotboll",
            "Viasat Sport-Premium",
            "Viasat Hockey",
            "Viasat Series"});
            this.comboBox1.Location = new System.Drawing.Point(38, 89);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 27);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Time and Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lboxTitles);
            this.Controls.Add(this.tbxDateTime);
            this.Controls.Add(this.btnDayfwd);
            this.Controls.Add(this.btnCurdate);
            this.Controls.Add(this.btnDaybwd);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "TV-Schedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDaybwd;
        private System.Windows.Forms.Button btnCurdate;
        private System.Windows.Forms.TextBox tbxDateTime;
        private System.Windows.Forms.Button btnDayfwd;
        private System.Windows.Forms.ListBox lboxTitles;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

