namespace TvTablaNew
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
            this.tbox_svt1 = new System.Windows.Forms.TextBox();
            this.lbl_svt1_date = new System.Windows.Forms.Label();
            this.lbl_svt1 = new System.Windows.Forms.Label();
            this.btn_svt1_next = new System.Windows.Forms.Button();
            this.btn_svt1_prev = new System.Windows.Forms.Button();
            this.btn_tv4_next = new System.Windows.Forms.Button();
            this.btn_tv4_prev = new System.Windows.Forms.Button();
            this.tbox_tv4 = new System.Windows.Forms.TextBox();
            this.lbl_tv4_date = new System.Windows.Forms.Label();
            this.lbl_tv4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbox_svt1
            // 
            this.tbox_svt1.Location = new System.Drawing.Point(20, 65);
            this.tbox_svt1.Multiline = true;
            this.tbox_svt1.Name = "tbox_svt1";
            this.tbox_svt1.ReadOnly = true;
            this.tbox_svt1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_svt1.Size = new System.Drawing.Size(220, 513);
            this.tbox_svt1.TabIndex = 0;
            this.tbox_svt1.TabStop = false;
            // 
            // lbl_svt1_date
            // 
            this.lbl_svt1_date.AutoSize = true;
            this.lbl_svt1_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_svt1_date.Location = new System.Drawing.Point(75, 41);
            this.lbl_svt1_date.Name = "lbl_svt1_date";
            this.lbl_svt1_date.Size = new System.Drawing.Size(86, 13);
            this.lbl_svt1_date.TabIndex = 1;
            this.lbl_svt1_date.Text = "Den xx xxxxxx";
            // 
            // lbl_svt1
            // 
            this.lbl_svt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_svt1.Location = new System.Drawing.Point(90, 12);
            this.lbl_svt1.Name = "lbl_svt1";
            this.lbl_svt1.Size = new System.Drawing.Size(84, 29);
            this.lbl_svt1.TabIndex = 4;
            this.lbl_svt1.Text = "SVT 1";
            // 
            // btn_svt1_next
            // 
            this.btn_svt1_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_svt1_next.Location = new System.Drawing.Point(200, 36);
            this.btn_svt1_next.Name = "btn_svt1_next";
            this.btn_svt1_next.Size = new System.Drawing.Size(40, 23);
            this.btn_svt1_next.TabIndex = 3;
            this.btn_svt1_next.Text = ">";
            this.btn_svt1_next.UseVisualStyleBackColor = true;
            this.btn_svt1_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_svt1_prev
            // 
            this.btn_svt1_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_svt1_prev.Location = new System.Drawing.Point(20, 36);
            this.btn_svt1_prev.Name = "btn_svt1_prev";
            this.btn_svt1_prev.Size = new System.Drawing.Size(40, 23);
            this.btn_svt1_prev.TabIndex = 2;
            this.btn_svt1_prev.Text = "<";
            this.btn_svt1_prev.UseVisualStyleBackColor = true;
            this.btn_svt1_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_tv4_next
            // 
            this.btn_tv4_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tv4_next.Location = new System.Drawing.Point(720, 36);
            this.btn_tv4_next.Name = "btn_tv4_next";
            this.btn_tv4_next.Size = new System.Drawing.Size(40, 23);
            this.btn_tv4_next.TabIndex = 5;
            this.btn_tv4_next.Text = ">";
            this.btn_tv4_next.UseVisualStyleBackColor = true;
            this.btn_tv4_next.Click += new System.EventHandler(this.btn_tv4_next_Click);
            // 
            // btn_tv4_prev
            // 
            this.btn_tv4_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tv4_prev.Location = new System.Drawing.Point(540, 36);
            this.btn_tv4_prev.Name = "btn_tv4_prev";
            this.btn_tv4_prev.Size = new System.Drawing.Size(40, 23);
            this.btn_tv4_prev.TabIndex = 6;
            this.btn_tv4_prev.Text = "<";
            this.btn_tv4_prev.UseVisualStyleBackColor = true;
            this.btn_tv4_prev.Click += new System.EventHandler(this.btn_tv4_prev_Click);
            // 
            // tbox_tv4
            // 
            this.tbox_tv4.Location = new System.Drawing.Point(540, 65);
            this.tbox_tv4.Multiline = true;
            this.tbox_tv4.Name = "tbox_tv4";
            this.tbox_tv4.ReadOnly = true;
            this.tbox_tv4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_tv4.Size = new System.Drawing.Size(220, 513);
            this.tbox_tv4.TabIndex = 7;
            // 
            // lbl_tv4_date
            // 
            this.lbl_tv4_date.AutoSize = true;
            this.lbl_tv4_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tv4_date.Location = new System.Drawing.Point(599, 41);
            this.lbl_tv4_date.Name = "lbl_tv4_date";
            this.lbl_tv4_date.Size = new System.Drawing.Size(80, 13);
            this.lbl_tv4_date.TabIndex = 8;
            this.lbl_tv4_date.Text = "Den xx xxxxx";
            // 
            // lbl_tv4
            // 
            this.lbl_tv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tv4.Location = new System.Drawing.Point(627, 9);
            this.lbl_tv4.Name = "lbl_tv4";
            this.lbl_tv4.Size = new System.Drawing.Size(67, 29);
            this.lbl_tv4.TabIndex = 9;
            this.lbl_tv4.Text = "TV4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 513);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 595);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_tv4);
            this.Controls.Add(this.lbl_tv4_date);
            this.Controls.Add(this.tbox_tv4);
            this.Controls.Add(this.btn_tv4_prev);
            this.Controls.Add(this.btn_tv4_next);
            this.Controls.Add(this.lbl_svt1);
            this.Controls.Add(this.btn_svt1_next);
            this.Controls.Add(this.btn_svt1_prev);
            this.Controls.Add(this.lbl_svt1_date);
            this.Controls.Add(this.tbox_svt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_svt1;
        private System.Windows.Forms.Label lbl_svt1_date;
        private System.Windows.Forms.Button btn_svt1_next;
        private System.Windows.Forms.Button btn_svt1_prev;
        private System.Windows.Forms.Label lbl_svt1;
        private System.Windows.Forms.Button btn_tv4_next;
        private System.Windows.Forms.Button btn_tv4_prev;
        private System.Windows.Forms.TextBox tbox_tv4;
        private System.Windows.Forms.Label lbl_tv4_date;
        private System.Windows.Forms.Label lbl_tv4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

