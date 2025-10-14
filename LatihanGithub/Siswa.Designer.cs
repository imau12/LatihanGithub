namespace LatihanGithub
{
    partial class Siswa
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
            this.lblSiswa = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblKelas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSiswa
            // 
            this.lblSiswa.AutoSize = true;
            this.lblSiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiswa.Location = new System.Drawing.Point(343, 9);
            this.lblSiswa.Name = "lblSiswa";
            this.lblSiswa.Size = new System.Drawing.Size(89, 26);
            this.lblSiswa.TabIndex = 0;
            this.lblSiswa.Text = "SISWA";
            this.lblSiswa.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(47, 58);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(59, 20);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama :";
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Location = new System.Drawing.Point(50, 100);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(56, 20);
            this.lblKelas.TabIndex = 2;
            this.lblKelas.Text = "Kelas :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKelas);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblSiswa);
            this.Name = "Siswa";
            this.Text = "Siswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSiswa;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Label label1;
    }
}