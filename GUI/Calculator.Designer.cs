namespace GUI
{
    partial class Calculator
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.new_btn = new System.Windows.Forms.Button();
            this.bagi_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.kali_btn = new System.Windows.Forms.Button();
            this.kurang_btn = new System.Windows.Forms.Button();
            this.tambah_btn = new System.Windows.Forms.Button();
            this.Data_bilangan = new System.Windows.Forms.GroupBox();
            this.Hasil = new System.Windows.Forms.Label();
            this.Hasil_txt = new System.Windows.Forms.TextBox();
            this.bilDua_txt = new System.Windows.Forms.TextBox();
            this.bilSatu_txt = new System.Windows.Forms.TextBox();
            this.bilKedua_lbl = new System.Windows.Forms.Label();
            this.bilKesatu_lbl = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.Data_bilangan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.new_btn);
            this.groupBox2.Controls.Add(this.bagi_btn);
            this.groupBox2.Controls.Add(this.close_btn);
            this.groupBox2.Controls.Add(this.kali_btn);
            this.groupBox2.Controls.Add(this.kurang_btn);
            this.groupBox2.Controls.Add(this.tambah_btn);
            this.groupBox2.Location = new System.Drawing.Point(102, 317);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(596, 99);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "| OPERATOR |";
            // 
            // new_btn
            // 
            this.new_btn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_btn.Location = new System.Drawing.Point(386, 36);
            this.new_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(84, 50);
            this.new_btn.TabIndex = 11;
            this.new_btn.Text = "New";
            this.new_btn.UseVisualStyleBackColor = true;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // bagi_btn
            // 
            this.bagi_btn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagi_btn.Location = new System.Drawing.Point(296, 36);
            this.bagi_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bagi_btn.Name = "bagi_btn";
            this.bagi_btn.Size = new System.Drawing.Size(62, 50);
            this.bagi_btn.TabIndex = 10;
            this.bagi_btn.Text = "/";
            this.bagi_btn.UseVisualStyleBackColor = true;
            this.bagi_btn.Click += new System.EventHandler(this.bagi_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(487, 41);
            this.close_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(99, 41);
            this.close_btn.TabIndex = 12;
            this.close_btn.Text = "close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // kali_btn
            // 
            this.kali_btn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kali_btn.Location = new System.Drawing.Point(197, 36);
            this.kali_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kali_btn.Name = "kali_btn";
            this.kali_btn.Size = new System.Drawing.Size(62, 50);
            this.kali_btn.TabIndex = 9;
            this.kali_btn.Text = "*";
            this.kali_btn.UseVisualStyleBackColor = true;
            this.kali_btn.Click += new System.EventHandler(this.kali_btn_Click);
            // 
            // kurang_btn
            // 
            this.kurang_btn.Font = new System.Drawing.Font("Arial Narrow", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kurang_btn.Location = new System.Drawing.Point(109, 36);
            this.kurang_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kurang_btn.Name = "kurang_btn";
            this.kurang_btn.Size = new System.Drawing.Size(62, 50);
            this.kurang_btn.TabIndex = 8;
            this.kurang_btn.Text = "-";
            this.kurang_btn.UseVisualStyleBackColor = true;
            this.kurang_btn.Click += new System.EventHandler(this.kurang_btn_Click);
            // 
            // tambah_btn
            // 
            this.tambah_btn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_btn.Location = new System.Drawing.Point(19, 36);
            this.tambah_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tambah_btn.Name = "tambah_btn";
            this.tambah_btn.Size = new System.Drawing.Size(62, 50);
            this.tambah_btn.TabIndex = 7;
            this.tambah_btn.Text = "+";
            this.tambah_btn.UseVisualStyleBackColor = true;
            this.tambah_btn.Click += new System.EventHandler(this.tambah_btn_Click);
            // 
            // Data_bilangan
            // 
            this.Data_bilangan.Controls.Add(this.Hasil);
            this.Data_bilangan.Controls.Add(this.Hasil_txt);
            this.Data_bilangan.Controls.Add(this.bilDua_txt);
            this.Data_bilangan.Controls.Add(this.bilSatu_txt);
            this.Data_bilangan.Controls.Add(this.bilKedua_lbl);
            this.Data_bilangan.Controls.Add(this.bilKesatu_lbl);
            this.Data_bilangan.Location = new System.Drawing.Point(102, 34);
            this.Data_bilangan.Name = "Data_bilangan";
            this.Data_bilangan.Size = new System.Drawing.Size(578, 245);
            this.Data_bilangan.TabIndex = 16;
            this.Data_bilangan.TabStop = false;
            this.Data_bilangan.Text = "| DATA BILANGAN |";
            // 
            // Hasil
            // 
            this.Hasil.AutoSize = true;
            this.Hasil.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hasil.Location = new System.Drawing.Point(6, 180);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(53, 21);
            this.Hasil.TabIndex = 5;
            this.Hasil.Text = "Hasil";
            // 
            // Hasil_txt
            // 
            this.Hasil_txt.Enabled = false;
            this.Hasil_txt.Location = new System.Drawing.Point(210, 165);
            this.Hasil_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Hasil_txt.Multiline = true;
            this.Hasil_txt.Name = "Hasil_txt";
            this.Hasil_txt.ReadOnly = true;
            this.Hasil_txt.Size = new System.Drawing.Size(228, 36);
            this.Hasil_txt.TabIndex = 4;
            this.Hasil_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bilDua_txt
            // 
            this.bilDua_txt.Location = new System.Drawing.Point(210, 105);
            this.bilDua_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bilDua_txt.Multiline = true;
            this.bilDua_txt.Name = "bilDua_txt";
            this.bilDua_txt.Size = new System.Drawing.Size(228, 36);
            this.bilDua_txt.TabIndex = 3;
            this.bilDua_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bilSatu_txt
            // 
            this.bilSatu_txt.Location = new System.Drawing.Point(210, 59);
            this.bilSatu_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bilSatu_txt.Multiline = true;
            this.bilSatu_txt.Name = "bilSatu_txt";
            this.bilSatu_txt.Size = new System.Drawing.Size(228, 36);
            this.bilSatu_txt.TabIndex = 1;
            this.bilSatu_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bilSatu_txt_KeyPress);
            // 
            // bilKedua_lbl
            // 
            this.bilKedua_lbl.AutoSize = true;
            this.bilKedua_lbl.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilKedua_lbl.Location = new System.Drawing.Point(6, 120);
            this.bilKedua_lbl.Name = "bilKedua_lbl";
            this.bilKedua_lbl.Size = new System.Drawing.Size(147, 21);
            this.bilKedua_lbl.TabIndex = 1;
            this.bilKedua_lbl.Text = "Bilangan Kedua";
            // 
            // bilKesatu_lbl
            // 
            this.bilKesatu_lbl.AutoSize = true;
            this.bilKesatu_lbl.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilKesatu_lbl.Location = new System.Drawing.Point(6, 60);
            this.bilKesatu_lbl.Name = "bilKesatu_lbl";
            this.bilKesatu_lbl.Size = new System.Drawing.Size(152, 21);
            this.bilKesatu_lbl.TabIndex = 0;
            this.bilKesatu_lbl.Text = "Bilangan Kesatu";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Data_bilangan);
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APLIKASI KALKULATOR";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.Data_bilangan.ResumeLayout(false);
            this.Data_bilangan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button bagi_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button kali_btn;
        private System.Windows.Forms.Button kurang_btn;
        private System.Windows.Forms.Button tambah_btn;
        private System.Windows.Forms.GroupBox Data_bilangan;
        private System.Windows.Forms.Label Hasil;
        private System.Windows.Forms.TextBox Hasil_txt;
        private System.Windows.Forms.TextBox bilDua_txt;
        private System.Windows.Forms.TextBox bilSatu_txt;
        private System.Windows.Forms.Label bilKedua_lbl;
        private System.Windows.Forms.Label bilKesatu_lbl;
    }
}