﻿namespace Dashboard.Controller
{
    partial class UserControlDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(305, 314);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(154, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Selamat datang di Dental Clinik";
            // 
            // UserControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl);
            this.Name = "UserControlDashboard";
            this.Size = new System.Drawing.Size(806, 669);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
    }
}
