namespace OgrenciKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOgrenciSil = new System.Windows.Forms.Button();
            this.btnOgrenciAra = new System.Windows.Forms.Button();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.rButonKiz = new System.Windows.Forms.RadioButton();
            this.rButonErkek = new System.Windows.Forms.RadioButton();
            this.cBoxBolum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTCno = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSonrakiOgrenci = new System.Windows.Forms.Button();
            this.btnOncekiOgrenci = new System.Windows.Forms.Button();
            this.lblOgrSayisi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBolum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTCno = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOgrenciSil);
            this.groupBox1.Controls.Add(this.btnOgrenciAra);
            this.groupBox1.Controls.Add(this.btnOgrenciEkle);
            this.groupBox1.Controls.Add(this.rButonKiz);
            this.groupBox1.Controls.Add(this.rButonErkek);
            this.groupBox1.Controls.Add(this.cBoxBolum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTCno);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(379, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciSil.Location = new System.Drawing.Point(294, 129);
            this.btnOgrenciSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(74, 39);
            this.btnOgrenciSil.TabIndex = 4;
            this.btnOgrenciSil.Text = "Öğrenci Sil";
            this.btnOgrenciSil.UseVisualStyleBackColor = true;
            this.btnOgrenciSil.Click += new System.EventHandler(this.btnOgrenciSil_Click);
            // 
            // btnOgrenciAra
            // 
            this.btnOgrenciAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciAra.Location = new System.Drawing.Point(294, 76);
            this.btnOgrenciAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnOgrenciAra.Name = "btnOgrenciAra";
            this.btnOgrenciAra.Size = new System.Drawing.Size(74, 39);
            this.btnOgrenciAra.TabIndex = 4;
            this.btnOgrenciAra.Text = "Öğrenci Ara";
            this.btnOgrenciAra.UseVisualStyleBackColor = true;
            this.btnOgrenciAra.Click += new System.EventHandler(this.btnOgrenciAra_Click);
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciEkle.Location = new System.Drawing.Point(294, 21);
            this.btnOgrenciEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(74, 39);
            this.btnOgrenciEkle.TabIndex = 4;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // rButonKiz
            // 
            this.rButonKiz.AutoSize = true;
            this.rButonKiz.Location = new System.Drawing.Point(196, 138);
            this.rButonKiz.Margin = new System.Windows.Forms.Padding(2);
            this.rButonKiz.Name = "rButonKiz";
            this.rButonKiz.Size = new System.Drawing.Size(48, 21);
            this.rButonKiz.TabIndex = 3;
            this.rButonKiz.TabStop = true;
            this.rButonKiz.Text = "Kız";
            this.rButonKiz.UseVisualStyleBackColor = true;
            this.rButonKiz.CheckedChanged += new System.EventHandler(this.rButonCinsiyet_CheckedChanged);
            // 
            // rButonErkek
            // 
            this.rButonErkek.AutoSize = true;
            this.rButonErkek.Location = new System.Drawing.Point(116, 138);
            this.rButonErkek.Margin = new System.Windows.Forms.Padding(2);
            this.rButonErkek.Name = "rButonErkek";
            this.rButonErkek.Size = new System.Drawing.Size(67, 21);
            this.rButonErkek.TabIndex = 3;
            this.rButonErkek.TabStop = true;
            this.rButonErkek.Text = "Erkek";
            this.rButonErkek.UseVisualStyleBackColor = true;
            this.rButonErkek.CheckedChanged += new System.EventHandler(this.rButonCinsiyet_CheckedChanged);
            // 
            // cBoxBolum
            // 
            this.cBoxBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxBolum.FormattingEnabled = true;
            this.cBoxBolum.Items.AddRange(new object[] {
            "Bilişim Teknolojileri",
            "Elektrik",
            "Elektronik",
            "Mobilya",
            "Tesisat"});
            this.cBoxBolum.Location = new System.Drawing.Point(109, 98);
            this.cBoxBolum.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxBolum.Name = "cBoxBolum";
            this.cBoxBolum.Size = new System.Drawing.Size(165, 25);
            this.cBoxBolum.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cinsiyet  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bölümü  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı Soyadı  :";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(109, 58);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(165, 23);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No  :";
            // 
            // txtTCno
            // 
            this.txtTCno.Location = new System.Drawing.Point(109, 27);
            this.txtTCno.Margin = new System.Windows.Forms.Padding(2);
            this.txtTCno.MaxLength = 11;
            this.txtTCno.Name = "txtTCno";
            this.txtTCno.Size = new System.Drawing.Size(165, 23);
            this.txtTCno.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSonrakiOgrenci);
            this.groupBox2.Controls.Add(this.btnOncekiOgrenci);
            this.groupBox2.Controls.Add(this.lblOgrSayisi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblBolum);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblTCno);
            this.groupBox2.Controls.Add(this.lblCinsiyet);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblAdSoyad);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(9, 209);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(379, 266);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenciler";
            // 
            // btnSonrakiOgrenci
            // 
            this.btnSonrakiOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonrakiOgrenci.Location = new System.Drawing.Point(294, 212);
            this.btnSonrakiOgrenci.Margin = new System.Windows.Forms.Padding(2);
            this.btnSonrakiOgrenci.Name = "btnSonrakiOgrenci";
            this.btnSonrakiOgrenci.Size = new System.Drawing.Size(74, 39);
            this.btnSonrakiOgrenci.TabIndex = 4;
            this.btnSonrakiOgrenci.Text = "Sonraki Öğrenci";
            this.btnSonrakiOgrenci.UseVisualStyleBackColor = true;
            this.btnSonrakiOgrenci.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnOncekiOgrenci
            // 
            this.btnOncekiOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOncekiOgrenci.Location = new System.Drawing.Point(8, 212);
            this.btnOncekiOgrenci.Margin = new System.Windows.Forms.Padding(2);
            this.btnOncekiOgrenci.Name = "btnOncekiOgrenci";
            this.btnOncekiOgrenci.Size = new System.Drawing.Size(74, 39);
            this.btnOncekiOgrenci.TabIndex = 4;
            this.btnOncekiOgrenci.Text = "Önceki Öğrenci ";
            this.btnOncekiOgrenci.UseVisualStyleBackColor = true;
            this.btnOncekiOgrenci.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblOgrSayisi
            // 
            this.lblOgrSayisi.AutoSize = true;
            this.lblOgrSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrSayisi.ForeColor = System.Drawing.Color.DarkRed;
            this.lblOgrSayisi.Location = new System.Drawing.Point(238, 222);
            this.lblOgrSayisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOgrSayisi.Name = "lblOgrSayisi";
            this.lblOgrSayisi.Size = new System.Drawing.Size(19, 20);
            this.lblOgrSayisi.TabIndex = 0;
            this.lblOgrSayisi.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(118, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Toplam Öğrenci\r\n Sayısı  :";
            // 
            // lblBolum
            // 
            this.lblBolum.AutoSize = true;
            this.lblBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolum.ForeColor = System.Drawing.Color.DarkRed;
            this.lblBolum.Location = new System.Drawing.Point(112, 113);
            this.lblBolum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBolum.Name = "lblBolum";
            this.lblBolum.Size = new System.Drawing.Size(0, 15);
            this.lblBolum.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(14, 113);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bölümü  :";
            // 
            // lblTCno
            // 
            this.lblTCno.AutoSize = true;
            this.lblTCno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCno.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTCno.Location = new System.Drawing.Point(112, 42);
            this.lblTCno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTCno.Name = "lblTCno";
            this.lblTCno.Size = new System.Drawing.Size(0, 15);
            this.lblTCno.TabIndex = 0;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCinsiyet.Location = new System.Drawing.Point(112, 153);
            this.lblCinsiyet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(0, 15);
            this.lblCinsiyet.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(14, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "TC Kimlik No  :";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAdSoyad.Location = new System.Drawing.Point(112, 74);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 15);
            this.lblAdSoyad.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(14, 153);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cinsiyet  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adı Soyadı  :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rButonKiz;
        private System.Windows.Forms.RadioButton rButonErkek;
        private System.Windows.Forms.ComboBox cBoxBolum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTCno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOgrenciSil;
        private System.Windows.Forms.Button btnOgrenciAra;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSonrakiOgrenci;
        private System.Windows.Forms.Button btnOncekiOgrenci;
        private System.Windows.Forms.Label lblOgrSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBolum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTCno;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
    }
}

