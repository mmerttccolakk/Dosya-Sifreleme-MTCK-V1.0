namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sifre_coz = new System.Windows.Forms.Button();
            this.sifrele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dosya_boyut = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dosya_adi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dosya_sec = new System.Windows.Forms.Button();
            this.dosya_yolu = new System.Windows.Forms.TextBox();
            this.Bildirimler = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.sifrele_fonk = new System.ComponentModel.BackgroundWorker();
            this.sifre_coz_fonk = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.Bildirimler.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sifre_coz
            // 
            this.sifre_coz.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_coz.Location = new System.Drawing.Point(216, 80);
            this.sifre_coz.Name = "sifre_coz";
            this.sifre_coz.Size = new System.Drawing.Size(187, 113);
            this.sifre_coz.TabIndex = 0;
            this.sifre_coz.Text = "ŞifreÇöz";
            this.sifre_coz.UseVisualStyleBackColor = true;
            this.sifre_coz.Click += new System.EventHandler(this.button1_Click);
            // 
            // sifrele
            // 
            this.sifrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrele.Location = new System.Drawing.Point(9, 80);
            this.sifrele.Name = "sifrele";
            this.sifrele.Size = new System.Drawing.Size(201, 113);
            this.sifrele.TabIndex = 1;
            this.sifrele.Text = "Şifrele";
            this.sifrele.UseVisualStyleBackColor = true;
            this.sifrele.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dosya_boyut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dosya_adi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dosya_sec);
            this.groupBox1.Controls.Add(this.dosya_yolu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dosya Seç";
            // 
            // dosya_boyut
            // 
            this.dosya_boyut.AutoSize = true;
            this.dosya_boyut.Location = new System.Drawing.Point(89, 66);
            this.dosya_boyut.Name = "dosya_boyut";
            this.dosya_boyut.Size = new System.Drawing.Size(0, 13);
            this.dosya_boyut.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dosya Boyutu:";
            // 
            // dosya_adi
            // 
            this.dosya_adi.AutoSize = true;
            this.dosya_adi.Location = new System.Drawing.Point(72, 47);
            this.dosya_adi.Name = "dosya_adi";
            this.dosya_adi.Size = new System.Drawing.Size(0, 13);
            this.dosya_adi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dosya Adı:";
            // 
            // dosya_sec
            // 
            this.dosya_sec.Location = new System.Drawing.Point(329, 20);
            this.dosya_sec.Name = "dosya_sec";
            this.dosya_sec.Size = new System.Drawing.Size(75, 23);
            this.dosya_sec.TabIndex = 4;
            this.dosya_sec.Text = "Dosya Seç";
            this.dosya_sec.UseVisualStyleBackColor = true;
            this.dosya_sec.Click += new System.EventHandler(this.dosya_sec_Click);
            // 
            // dosya_yolu
            // 
            this.dosya_yolu.Enabled = false;
            this.dosya_yolu.Location = new System.Drawing.Point(7, 20);
            this.dosya_yolu.Name = "dosya_yolu";
            this.dosya_yolu.Size = new System.Drawing.Size(316, 20);
            this.dosya_yolu.TabIndex = 3;
            // 
            // Bildirimler
            // 
            this.Bildirimler.Controls.Add(this.label5);
            this.Bildirimler.Controls.Add(this.label4);
            this.Bildirimler.Controls.Add(this.label3);
            this.Bildirimler.Controls.Add(this.progressBar1);
            this.Bildirimler.Location = new System.Drawing.Point(12, 325);
            this.Bildirimler.Name = "Bildirimler";
            this.Bildirimler.Size = new System.Drawing.Size(410, 124);
            this.Bildirimler.TabIndex = 4;
            this.Bildirimler.TabStop = false;
            this.Bildirimler.Text = "İşlem Bildirimi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kalan Veri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "İşlenen Veri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(315, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "%100";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 78);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(397, 40);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.sifre);
            this.groupBox2.Controls.Add(this.sifre_coz);
            this.groupBox2.Controls.Add(this.sifrele);
            this.groupBox2.Location = new System.Drawing.Point(13, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 199);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dosya Şifreleme / Çözme";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sifre
            // 
            this.sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.Location = new System.Drawing.Point(9, 20);
            this.sifre.MaxLength = 100;
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(394, 44);
            this.sifre.TabIndex = 2;
            this.sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // sifrele_fonk
            // 
            this.sifrele_fonk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.sifrele_fonk_DoWork);
            // 
            // sifre_coz_fonk
            // 
            this.sifre_coz_fonk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.sifre_coz_fonk_DoWork);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Bildirimler);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MTCK V1.0 SIFRELEME";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Bildirimler.ResumeLayout(false);
            this.Bildirimler.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sifre_coz;
        private System.Windows.Forms.Button sifrele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dosya_sec;
        private System.Windows.Forms.TextBox dosya_yolu;
        private System.Windows.Forms.Label dosya_adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dosya_boyut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Bildirimler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker sifrele_fonk;
        private System.ComponentModel.BackgroundWorker sifre_coz_fonk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

