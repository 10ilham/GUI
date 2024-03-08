namespace GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.No_induk = new System.Windows.Forms.TextBox();
            this.Mahasiswa = new System.Windows.Forms.TextBox();
            this.Laki_laki = new System.Windows.Forms.RadioButton();
            this.Perempuan = new System.Windows.Forms.RadioButton();
            this.Agama_lsb = new System.Windows.Forms.ComboBox();
            this.Alamat_lsb = new System.Windows.Forms.TextBox();
            this.Jurusan_lsb = new System.Windows.Forms.ComboBox();
            this.Jenjang_lsb = new System.Windows.Forms.ComboBox();
            this.Kota_lsb = new System.Windows.Forms.ListBox();
            this.Telpon_lsb = new System.Windows.Forms.TextBox();
            this.Tampil_lsb = new System.Windows.Forms.Button();
            this.Tambah_lsb = new System.Windows.Forms.Button();
            this.Keluar_lsb = new System.Windows.Forms.Button();
            this.noinduk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(240, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entry Data Mahasiswa";
            // 
            // No_induk
            // 
            this.No_induk.Location = new System.Drawing.Point(268, 89);
            this.No_induk.Name = "No_induk";
            this.No_induk.Size = new System.Drawing.Size(100, 22);
            this.No_induk.TabIndex = 1;
            this.No_induk.TextChanged += new System.EventHandler(this.No_induk_TextChanged);
            this.No_induk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.No_induk_KeyPress);
            // 
            // Mahasiswa
            // 
            this.Mahasiswa.Location = new System.Drawing.Point(268, 117);
            this.Mahasiswa.Name = "Mahasiswa";
            this.Mahasiswa.Size = new System.Drawing.Size(231, 22);
            this.Mahasiswa.TabIndex = 2;
            this.Mahasiswa.TextChanged += new System.EventHandler(this.Mahasiswa_TextChanged);
            // 
            // Laki_laki
            // 
            this.Laki_laki.AutoSize = true;
            this.Laki_laki.Location = new System.Drawing.Point(265, 145);
            this.Laki_laki.Name = "Laki_laki";
            this.Laki_laki.Size = new System.Drawing.Size(88, 20);
            this.Laki_laki.TabIndex = 3;
            this.Laki_laki.TabStop = true;
            this.Laki_laki.Text = "Laki - Laki";
            this.Laki_laki.UseVisualStyleBackColor = true;
            this.Laki_laki.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Perempuan
            // 
            this.Perempuan.AutoSize = true;
            this.Perempuan.Location = new System.Drawing.Point(384, 145);
            this.Perempuan.Name = "Perempuan";
            this.Perempuan.Size = new System.Drawing.Size(98, 20);
            this.Perempuan.TabIndex = 4;
            this.Perempuan.TabStop = true;
            this.Perempuan.Text = "Perempuan";
            this.Perempuan.UseVisualStyleBackColor = true;
            // 
            // Agama_lsb
            // 
            this.Agama_lsb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Agama_lsb.FormattingEnabled = true;
            this.Agama_lsb.Location = new System.Drawing.Point(268, 171);
            this.Agama_lsb.Name = "Agama_lsb";
            this.Agama_lsb.Size = new System.Drawing.Size(219, 24);
            this.Agama_lsb.TabIndex = 5;
            this.Agama_lsb.SelectedIndexChanged += new System.EventHandler(this.Agama_lsb_SelectedIndexChanged);
            // 
            // Alamat_lsb
            // 
            this.Alamat_lsb.Location = new System.Drawing.Point(268, 262);
            this.Alamat_lsb.Multiline = true;
            this.Alamat_lsb.Name = "Alamat_lsb";
            this.Alamat_lsb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Alamat_lsb.Size = new System.Drawing.Size(306, 73);
            this.Alamat_lsb.TabIndex = 6;
            this.Alamat_lsb.TextChanged += new System.EventHandler(this.Alamat_lsb_TextChanged);
            // 
            // Jurusan_lsb
            // 
            this.Jurusan_lsb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Jurusan_lsb.FormattingEnabled = true;
            this.Jurusan_lsb.Items.AddRange(new object[] {
            "Komputer dan Bisnis",
            "Rekayasa Elektro dan Mekatronika",
            "Rekayasa Mesin dan Industri Pertanian."});
            this.Jurusan_lsb.Location = new System.Drawing.Point(268, 201);
            this.Jurusan_lsb.Name = "Jurusan_lsb";
            this.Jurusan_lsb.Size = new System.Drawing.Size(219, 24);
            this.Jurusan_lsb.TabIndex = 7;
            // 
            // Jenjang_lsb
            // 
            this.Jenjang_lsb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Jenjang_lsb.FormattingEnabled = true;
            this.Jenjang_lsb.Items.AddRange(new object[] {
            "D3 Teknik Informatika",
            "D4 TPPL",
            "D3 Teknik Mesin",
            "D3 Teknik Elektro"});
            this.Jenjang_lsb.Location = new System.Drawing.Point(268, 231);
            this.Jenjang_lsb.Name = "Jenjang_lsb";
            this.Jenjang_lsb.Size = new System.Drawing.Size(219, 24);
            this.Jenjang_lsb.TabIndex = 8;
            // 
            // Kota_lsb
            // 
            this.Kota_lsb.FormattingEnabled = true;
            this.Kota_lsb.ItemHeight = 16;
            this.Kota_lsb.Location = new System.Drawing.Point(268, 341);
            this.Kota_lsb.Name = "Kota_lsb";
            this.Kota_lsb.Size = new System.Drawing.Size(136, 100);
            this.Kota_lsb.TabIndex = 9;
            this.Kota_lsb.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Telpon_lsb
            // 
            this.Telpon_lsb.Location = new System.Drawing.Point(410, 341);
            this.Telpon_lsb.Name = "Telpon_lsb";
            this.Telpon_lsb.Size = new System.Drawing.Size(164, 22);
            this.Telpon_lsb.TabIndex = 10;
            // 
            // Tampil_lsb
            // 
            this.Tampil_lsb.BackColor = System.Drawing.SystemColors.Control;
            this.Tampil_lsb.Location = new System.Drawing.Point(410, 369);
            this.Tampil_lsb.Name = "Tampil_lsb";
            this.Tampil_lsb.Size = new System.Drawing.Size(75, 28);
            this.Tampil_lsb.TabIndex = 11;
            this.Tampil_lsb.Text = "Tampil";
            this.Tampil_lsb.UseVisualStyleBackColor = false;
            this.Tampil_lsb.Click += new System.EventHandler(this.Tampil_lsb_Click);
            // 
            // Tambah_lsb
            // 
            this.Tambah_lsb.AutoSize = true;
            this.Tambah_lsb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tambah_lsb.Location = new System.Drawing.Point(499, 369);
            this.Tambah_lsb.Name = "Tambah_lsb";
            this.Tambah_lsb.Size = new System.Drawing.Size(75, 28);
            this.Tambah_lsb.TabIndex = 12;
            this.Tambah_lsb.Text = "Tambah";
            this.Tambah_lsb.UseVisualStyleBackColor = false;
            this.Tambah_lsb.Click += new System.EventHandler(this.Tambah_lsb_Click);
            // 
            // Keluar_lsb
            // 
            this.Keluar_lsb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Keluar_lsb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Keluar_lsb.Location = new System.Drawing.Point(410, 402);
            this.Keluar_lsb.Name = "Keluar_lsb";
            this.Keluar_lsb.Size = new System.Drawing.Size(164, 37);
            this.Keluar_lsb.TabIndex = 13;
            this.Keluar_lsb.Text = "Keluar";
            this.Keluar_lsb.UseVisualStyleBackColor = true;
            this.Keluar_lsb.Click += new System.EventHandler(this.Keluar_Click);
            // 
            // noinduk
            // 
            this.noinduk.AutoSize = true;
            this.noinduk.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noinduk.Location = new System.Drawing.Point(136, 89);
            this.noinduk.Name = "noinduk";
            this.noinduk.Size = new System.Drawing.Size(99, 29);
            this.noinduk.TabIndex = 14;
            this.noinduk.Text = "No. Induk";
            this.noinduk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.noinduk.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nama Mahasiswa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseCompatibleTextRendering = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Jenis Kelamin";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Agama";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Jurusan";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(106, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Jenjang Studi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(163, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Alamat";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.UseCompatibleTextRendering = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(92, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 29);
            this.label9.TabIndex = 21;
            this.label9.Text = "Kota - Telepon";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.UseCompatibleTextRendering = true;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(838, 583);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.noinduk);
            this.Controls.Add(this.Keluar_lsb);
            this.Controls.Add(this.Tambah_lsb);
            this.Controls.Add(this.Tampil_lsb);
            this.Controls.Add(this.Telpon_lsb);
            this.Controls.Add(this.Kota_lsb);
            this.Controls.Add(this.Jenjang_lsb);
            this.Controls.Add(this.Jurusan_lsb);
            this.Controls.Add(this.Alamat_lsb);
            this.Controls.Add(this.Agama_lsb);
            this.Controls.Add(this.Perempuan);
            this.Controls.Add(this.Laki_laki);
            this.Controls.Add(this.Mahasiswa);
            this.Controls.Add(this.No_induk);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DATA MAHASISWA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox No_induk;
        private System.Windows.Forms.TextBox Mahasiswa;
        private System.Windows.Forms.RadioButton Laki_laki;
        private System.Windows.Forms.RadioButton Perempuan;
        private System.Windows.Forms.ComboBox Agama_lsb;
        private System.Windows.Forms.TextBox Alamat_lsb;
        private System.Windows.Forms.ComboBox Jurusan_lsb;
        private System.Windows.Forms.ComboBox Jenjang_lsb;
        private System.Windows.Forms.ListBox Kota_lsb;
        private System.Windows.Forms.TextBox Telpon_lsb;
        private System.Windows.Forms.Button Tampil_lsb;
        private System.Windows.Forms.Button Tambah_lsb;
        private System.Windows.Forms.Button Keluar_lsb;
        private System.Windows.Forms.Label noinduk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

