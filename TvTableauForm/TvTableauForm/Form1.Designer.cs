﻿namespace TvTableauForm
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
            this.tbxShowTvTableau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxShowTvTableau
            // 
            this.tbxShowTvTableau.Location = new System.Drawing.Point(12, 12);
            this.tbxShowTvTableau.Multiline = true;
            this.tbxShowTvTableau.Name = "tbxShowTvTableau";
            this.tbxShowTvTableau.ReadOnly = true;
            this.tbxShowTvTableau.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxShowTvTableau.Size = new System.Drawing.Size(562, 462);
            this.tbxShowTvTableau.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 486);
            this.Controls.Add(this.tbxShowTvTableau);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxShowTvTableau;
    }
}

