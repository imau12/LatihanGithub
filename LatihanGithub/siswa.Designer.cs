namespace LatihanGithub
{
    partial class siswa
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
            this.lblNama = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKelas = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(39, 48);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(59, 20);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama :";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(39, 94);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(67, 20);
            this.lblAlamat.TabIndex = 1;
            this.lblAlamat.Text = "Alamat :";
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(39, 133);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(56, 20);
            this.lblKelas.TabIndex = 2;
            this.lblKelas.Text = "Kelas :";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(136, 45);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(100, 26);
            this.txtNama.TabIndex = 3;
            // 
            // txtKelas
            // 
            this.txtKelas.Location = new System.Drawing.Point(136, 133);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.Size = new System.Drawing.Size(100, 26);
            this.txtKelas.TabIndex = 4;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(136, 94);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(100, 26);
            this.txtAlamat.TabIndex = 5;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(76, 193);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 6;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(293, 193);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 7;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(183, 193);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(770, 188);
            this.dataGridView1.TabIndex = 9;
            // 
            // siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblNama);
            this.Name = "siswa";
            this.Text = "siswa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtKelas;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}