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
            this.SuspendLayout();
            // 
            // btnDaybwd
            // 
            this.btnDaybwd.AutoSize = true;
            this.btnDaybwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaybwd.Location = new System.Drawing.Point(449, 711);
            this.btnDaybwd.Name = "btnDaybwd";
            this.btnDaybwd.Size = new System.Drawing.Size(155, 30);
            this.btnDaybwd.TabIndex = 0;
            this.btnDaybwd.Text = "Go back one day";
            this.btnDaybwd.UseVisualStyleBackColor = true;
            this.btnDaybwd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCurdate
            // 
            this.btnCurdate.AutoSize = true;
            this.btnCurdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurdate.Location = new System.Drawing.Point(644, 711);
            this.btnCurdate.Name = "btnCurdate";
            this.btnCurdate.Size = new System.Drawing.Size(155, 30);
            this.btnCurdate.TabIndex = 1;
            this.btnCurdate.Text = "Go to current date";
            this.btnCurdate.UseVisualStyleBackColor = true;
            this.btnCurdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDayfwd
            // 
            this.btnDayfwd.AutoSize = true;
            this.btnDayfwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDayfwd.Location = new System.Drawing.Point(839, 711);
            this.btnDayfwd.Name = "btnDayfwd";
            this.btnDayfwd.Size = new System.Drawing.Size(165, 30);
            this.btnDayfwd.TabIndex = 2;
            this.btnDayfwd.Text = "Go one day forward";
            this.btnDayfwd.UseVisualStyleBackColor = true;
            this.btnDayfwd.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbxDateTime
            // 
            this.tbxDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDateTime.Location = new System.Drawing.Point(570, 42);
            this.tbxDateTime.Name = "tbxDateTime";
            this.tbxDateTime.ReadOnly = true;
            this.tbxDateTime.Size = new System.Drawing.Size(286, 34);
            this.tbxDateTime.TabIndex = 4;
            this.tbxDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lboxTitles
            // 
            this.lboxTitles.FormattingEnabled = true;
            this.lboxTitles.ItemHeight = 16;
            this.lboxTitles.Location = new System.Drawing.Point(449, 121);
            this.lboxTitles.Name = "lboxTitles";
            this.lboxTitles.Size = new System.Drawing.Size(555, 484);
            this.lboxTitles.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "svt1",
            "svt2"});
            this.comboBox1.Location = new System.Drawing.Point(410, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Form1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 803);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lboxTitles);
            this.Controls.Add(this.tbxDateTime);
            this.Controls.Add(this.btnDayfwd);
            this.Controls.Add(this.btnCurdate);
            this.Controls.Add(this.btnDaybwd);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

