namespace Dashboard
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
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnDokter = new System.Windows.Forms.Button();
            this.btnPendaftaran = new System.Windows.Forms.Button();
            this.btnRekamMedis = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Swis721 Blk BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(140, 50);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(255, 84);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnDokter
            // 
            this.btnDokter.Font = new System.Drawing.Font("Swis721 Blk BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDokter.Location = new System.Drawing.Point(140, 280);
            this.btnDokter.Name = "btnDokter";
            this.btnDokter.Size = new System.Drawing.Size(255, 84);
            this.btnDokter.TabIndex = 1;
            this.btnDokter.Text = "Dokter";
            this.btnDokter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDokter.UseVisualStyleBackColor = true;
            // 
            // btnPendaftaran
            // 
            this.btnPendaftaran.Font = new System.Drawing.Font("Swis721 Blk BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendaftaran.Location = new System.Drawing.Point(140, 165);
            this.btnPendaftaran.Name = "btnPendaftaran";
            this.btnPendaftaran.Size = new System.Drawing.Size(255, 84);
            this.btnPendaftaran.TabIndex = 2;
            this.btnPendaftaran.Text = "Pendaftaran";
            this.btnPendaftaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPendaftaran.UseVisualStyleBackColor = true;
            this.btnPendaftaran.Click += new System.EventHandler(this.btnPendaftaran_Click);
            // 
            // btnRekamMedis
            // 
            this.btnRekamMedis.Font = new System.Drawing.Font("Swis721 Blk BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRekamMedis.Location = new System.Drawing.Point(140, 510);
            this.btnRekamMedis.Name = "btnRekamMedis";
            this.btnRekamMedis.Size = new System.Drawing.Size(255, 94);
            this.btnRekamMedis.TabIndex = 3;
            this.btnRekamMedis.Text = "Rekam Medis";
            this.btnRekamMedis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRekamMedis.UseVisualStyleBackColor = true;
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Font = new System.Drawing.Font("Swis721 Blk BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaksi.Location = new System.Drawing.Point(140, 395);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(255, 84);
            this.btnTransaksi.TabIndex = 4;
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaksi.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Swis721 Blk BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(140, 635);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(255, 84);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "History";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(518, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(806, 669);
            this.pnlMain.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnTransaksi);
            this.Controls.Add(this.btnRekamMedis);
            this.Controls.Add(this.btnPendaftaran);
            this.Controls.Add(this.btnDokter);
            this.Controls.Add(this.btnDashboard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnDokter;
        private System.Windows.Forms.Button btnPendaftaran;
        private System.Windows.Forms.Button btnRekamMedis;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Panel pnlMain;
    }
}

