namespace asansor
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_teklisayisi = new System.Windows.Forms.TextBox();
            this.txt_ciftlisayisi = new System.Windows.Forms.TextBox();
            this.btn_olustur = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_otobusismi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_getir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nereye = new System.Windows.Forms.TextBox();
            this.txt_nereden = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ciftfiyat = new System.Windows.Forms.TextBox();
            this.txt_teklifiyat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.date_kalkis = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1231, 752);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(155, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otobüs Konfigirasyonu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tekli koltuk sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Çift Koltuk sayısı:";
            // 
            // txt_teklisayisi
            // 
            this.txt_teklisayisi.Location = new System.Drawing.Point(221, 116);
            this.txt_teklisayisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_teklisayisi.Name = "txt_teklisayisi";
            this.txt_teklisayisi.Size = new System.Drawing.Size(243, 22);
            this.txt_teklisayisi.TabIndex = 4;
            this.txt_teklisayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_teklisayisi_KeyPress);
            // 
            // txt_ciftlisayisi
            // 
            this.txt_ciftlisayisi.Location = new System.Drawing.Point(221, 158);
            this.txt_ciftlisayisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ciftlisayisi.Name = "txt_ciftlisayisi";
            this.txt_ciftlisayisi.Size = new System.Drawing.Size(243, 22);
            this.txt_ciftlisayisi.TabIndex = 5;
            this.txt_ciftlisayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ciftlisayisi_KeyPress);
            // 
            // btn_olustur
            // 
            this.btn_olustur.Location = new System.Drawing.Point(93, 395);
            this.btn_olustur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_olustur.Name = "btn_olustur";
            this.btn_olustur.Size = new System.Drawing.Size(395, 41);
            this.btn_olustur.TabIndex = 6;
            this.btn_olustur.Tag = "0";
            this.btn_olustur.Text = "Oluştur";
            this.btn_olustur.UseVisualStyleBackColor = true;
            this.btn_olustur.Click += new System.EventHandler(this.btn_olustur_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Location = new System.Drawing.Point(497, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 715);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(989, 73);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 715);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tekli Koltuk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(841, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Çift Koltuk";
            // 
            // txt_otobusismi
            // 
            this.txt_otobusismi.Location = new System.Drawing.Point(191, 478);
            this.txt_otobusismi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_otobusismi.Name = "txt_otobusismi";
            this.txt_otobusismi.Size = new System.Drawing.Size(187, 22);
            this.txt_otobusismi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 481);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Otobüs İsmi";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(387, 478);
            this.btn_kaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(101, 28);
            this.btn_kaydet.TabIndex = 13;
            this.btn_kaydet.Tag = "0";
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 524);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // btn_getir
            // 
            this.btn_getir.Location = new System.Drawing.Point(387, 522);
            this.btn_getir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_getir.Name = "btn_getir";
            this.btn_getir.Size = new System.Drawing.Size(100, 26);
            this.btn_getir.TabIndex = 15;
            this.btn_getir.Tag = "0";
            this.btn_getir.Text = "Getir";
            this.btn_getir.UseVisualStyleBackColor = true;
            this.btn_getir.Click += new System.EventHandler(this.btn_getir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 528);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Otobüs İsmi";
            // 
            // txt_nereye
            // 
            this.txt_nereye.Location = new System.Drawing.Point(221, 238);
            this.txt_nereye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nereye.Name = "txt_nereye";
            this.txt_nereye.Size = new System.Drawing.Size(243, 22);
            this.txt_nereye.TabIndex = 20;
            // 
            // txt_nereden
            // 
            this.txt_nereden.Location = new System.Drawing.Point(221, 197);
            this.txt_nereden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nereden.Name = "txt_nereden";
            this.txt_nereden.Size = new System.Drawing.Size(243, 22);
            this.txt_nereden.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 241);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nereye:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 201);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nereden:";
            // 
            // txt_ciftfiyat
            // 
            this.txt_ciftfiyat.Location = new System.Drawing.Point(221, 319);
            this.txt_ciftfiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ciftfiyat.Name = "txt_ciftfiyat";
            this.txt_ciftfiyat.Size = new System.Drawing.Size(243, 22);
            this.txt_ciftfiyat.TabIndex = 24;
            this.txt_ciftfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ciftfiyat_KeyPress);
            // 
            // txt_teklifiyat
            // 
            this.txt_teklifiyat.Location = new System.Drawing.Point(221, 278);
            this.txt_teklifiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_teklifiyat.Name = "txt_teklifiyat";
            this.txt_teklifiyat.Size = new System.Drawing.Size(243, 22);
            this.txt_teklifiyat.TabIndex = 23;
            this.txt_teklifiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_teklifiyat_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 322);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Çift Koltuk Fiyatı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 282);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tekli Koltuk Fiyatı:";
            // 
            // date_kalkis
            // 
            this.date_kalkis.Location = new System.Drawing.Point(221, 359);
            this.date_kalkis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_kalkis.Name = "date_kalkis";
            this.date_kalkis.Size = new System.Drawing.Size(265, 22);
            this.date_kalkis.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 363);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Kalkış Tarihi:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 570);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 27;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 570);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Buton Adı:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(111, 570);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(111, 608);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "label14";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(111, 647);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 16);
            this.label16.TabIndex = 32;
            this.label16.Text = "label16";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 820);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.date_kalkis);
            this.Controls.Add(this.txt_ciftfiyat);
            this.Controls.Add(this.txt_teklifiyat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_nereye);
            this.Controls.Add(this.txt_nereden);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_getir);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_otobusismi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_olustur);
            this.Controls.Add(this.txt_ciftlisayisi);
            this.Controls.Add(this.txt_teklisayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Otobüs";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_teklisayisi;
        private System.Windows.Forms.TextBox txt_ciftlisayisi;
        private System.Windows.Forms.Button btn_olustur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_otobusismi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_getir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nereye;
        private System.Windows.Forms.TextBox txt_nereden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ciftfiyat;
        private System.Windows.Forms.TextBox txt_teklifiyat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker date_kalkis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
    }
}