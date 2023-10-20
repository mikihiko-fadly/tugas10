namespace tugas10
{
    partial class AplikasiPendaftaranMahasiswa
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
            this.dataGridViewMataKuliah = new System.Windows.Forms.DataGridView();
            this.btnmatkul = new System.Windows.Forms.Button();
            this.btnmahasiswa = new System.Windows.Forms.Button();
            this.btnjurusan = new System.Windows.Forms.Button();
            this.btnpendaftaran = new System.Windows.Forms.Button();
            this.dataGridViewMahasiswa = new System.Windows.Forms.DataGridView();
            this.dataGridViewJurusan = new System.Windows.Forms.DataGridView();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMataKuliah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMahasiswa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJurusan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMataKuliah
            // 
            this.dataGridViewMataKuliah.AllowUserToOrderColumns = true;
            this.dataGridViewMataKuliah.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMataKuliah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMataKuliah.Location = new System.Drawing.Point(368, 276);
            this.dataGridViewMataKuliah.Name = "dataGridViewMataKuliah";
            this.dataGridViewMataKuliah.Size = new System.Drawing.Size(235, 144);
            this.dataGridViewMataKuliah.TabIndex = 4;
            // 
            // btnmatkul
            // 
            this.btnmatkul.BackColor = System.Drawing.SystemColors.Info;
            this.btnmatkul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmatkul.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnmatkul.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnmatkul.Location = new System.Drawing.Point(368, 247);
            this.btnmatkul.Name = "btnmatkul";
            this.btnmatkul.Size = new System.Drawing.Size(235, 23);
            this.btnmatkul.TabIndex = 7;
            this.btnmatkul.Text = "Mata Kuliah";
            this.btnmatkul.UseVisualStyleBackColor = false;
            this.btnmatkul.Click += new System.EventHandler(this.btnmatkul_Click_1);
            // 
            // btnmahasiswa
            // 
            this.btnmahasiswa.BackColor = System.Drawing.SystemColors.Info;
            this.btnmahasiswa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmahasiswa.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmahasiswa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnmahasiswa.Location = new System.Drawing.Point(21, 60);
            this.btnmahasiswa.Name = "btnmahasiswa";
            this.btnmahasiswa.Size = new System.Drawing.Size(341, 23);
            this.btnmahasiswa.TabIndex = 8;
            this.btnmahasiswa.Text = "Mahasiswa";
            this.btnmahasiswa.UseVisualStyleBackColor = false;
            this.btnmahasiswa.Click += new System.EventHandler(this.btnmahasiswa_Click);
            // 
            // btnjurusan
            // 
            this.btnjurusan.BackColor = System.Drawing.SystemColors.Info;
            this.btnjurusan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnjurusan.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnjurusan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnjurusan.Location = new System.Drawing.Point(368, 59);
            this.btnjurusan.Name = "btnjurusan";
            this.btnjurusan.Size = new System.Drawing.Size(235, 23);
            this.btnjurusan.TabIndex = 9;
            this.btnjurusan.Text = "Jurusan";
            this.btnjurusan.UseVisualStyleBackColor = false;
            this.btnjurusan.Click += new System.EventHandler(this.btnjurusan_Click);
            // 
            // btnpendaftaran
            // 
            this.btnpendaftaran.BackColor = System.Drawing.SystemColors.Info;
            this.btnpendaftaran.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpendaftaran.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnpendaftaran.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnpendaftaran.Location = new System.Drawing.Point(43, 602);
            this.btnpendaftaran.Name = "btnpendaftaran";
            this.btnpendaftaran.Size = new System.Drawing.Size(541, 23);
            this.btnpendaftaran.TabIndex = 10;
            this.btnpendaftaran.Text = "Tampilkan Data";
            this.btnpendaftaran.UseVisualStyleBackColor = false;
            this.btnpendaftaran.Click += new System.EventHandler(this.btnpendaftaran_Click);
            // 
            // dataGridViewMahasiswa
            // 
            this.dataGridViewMahasiswa.AllowUserToOrderColumns = true;
            this.dataGridViewMahasiswa.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMahasiswa.Location = new System.Drawing.Point(21, 89);
            this.dataGridViewMahasiswa.Name = "dataGridViewMahasiswa";
            this.dataGridViewMahasiswa.Size = new System.Drawing.Size(341, 331);
            this.dataGridViewMahasiswa.TabIndex = 11;
            this.dataGridViewMahasiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMahasiswa_CellContentClick);
            // 
            // dataGridViewJurusan
            // 
            this.dataGridViewJurusan.AllowUserToOrderColumns = true;
            this.dataGridViewJurusan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewJurusan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJurusan.Location = new System.Drawing.Point(368, 89);
            this.dataGridViewJurusan.Name = "dataGridViewJurusan";
            this.dataGridViewJurusan.Size = new System.Drawing.Size(235, 152);
            this.dataGridViewJurusan.TabIndex = 12;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToOrderColumns = true;
            this.dataGridViewData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(43, 435);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(541, 161);
            this.dataGridViewData.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "DATA MAHASISWA ";
            // 
            // AplikasiPendaftaranMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(628, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.dataGridViewJurusan);
            this.Controls.Add(this.dataGridViewMahasiswa);
            this.Controls.Add(this.btnpendaftaran);
            this.Controls.Add(this.btnjurusan);
            this.Controls.Add(this.btnmahasiswa);
            this.Controls.Add(this.btnmatkul);
            this.Controls.Add(this.dataGridViewMataKuliah);
            this.Name = "AplikasiPendaftaranMahasiswa";
            this.Text = "Data Mahasiswa";
            this.Load += new System.EventHandler(this.AplikasiPendaftaranMahasiswa_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMataKuliah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMahasiswa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJurusan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewMataKuliah;
        private System.Windows.Forms.Button btnmatkul;
        private System.Windows.Forms.Button btnmahasiswa;
        private System.Windows.Forms.Button btnjurusan;
        private System.Windows.Forms.Button btnpendaftaran;
        private System.Windows.Forms.DataGridView dataGridViewMahasiswa;
        private System.Windows.Forms.DataGridView dataGridViewJurusan;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Label label1;
    }
}

