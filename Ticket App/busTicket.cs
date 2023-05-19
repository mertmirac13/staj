using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace asansor
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        string[] otobusler = new string[20];
        int teklisayisi;
        int ciftsayisi;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Secenekler secondform = new Secenekler();
            secondform.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("otobusbilgileri.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(';');
                ortakdegiskenler.otobusadi.Add(components[0]);
                ortakdegiskenler.teklisayisi.Add(components[1]);
                ortakdegiskenler.ciftlisayisi.Add(components[2]);
                //ortakdegiskenler.nereden.Add(components[3]);
                //ortakdegiskenler.nereye.Add(components[4]);
                //ortakdegiskenler.teklifiyati.Add(components[5]);
                //ortakdegiskenler.ciftfiyati.Add(components[6]);
                //ortakdegiskenler.kalkistarihi.Add(components[7]);
            }
            sr.Close();

            otobusler = ortakdegiskenler.otobusadi.ToArray();
            ortakdegiskenler.otobusadi.ToArray(); 
            comboBox1.Items.AddRange(otobusler);          
        }

        private void temizle()
        {
            for (int i = 0; i < butonlistesi.Length; i++)
            {
                this.Controls.Remove(butonlistesi[i]);
            }
        }
        Button[] butonlistesi;
        int toplambuton = 0;
        string btek;
        string bikili;
        private void btn_getir_Click(object sender, EventArgs e)
        {

           
            StreamReader sr = new StreamReader("otobusbilgileri.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                ortakdegiskenler.otobusadi.Add(components[0]);
                ortakdegiskenler.teklisayisi.Add(components[1]);
                ortakdegiskenler.ciftlisayisi.Add(components[2]);
                ortakdegiskenler.nereden.Add(components[3]);
                ortakdegiskenler.nereye.Add(components[4]);
                ortakdegiskenler.teklifiyati.Add(components[5]);
                ortakdegiskenler.ciftfiyati.Add(components[6]);
                ortakdegiskenler.kalkistarihi.Add(components[7]);
            }
            sr.Close();
                      
            

            teklisayisi = Convert.ToInt16(ortakdegiskenler.teklisayisi[Array.IndexOf(ortakdegiskenler.otobusadi.ToArray(), comboBox1.Text)]);
            ciftsayisi = Convert.ToInt16(ortakdegiskenler.ciftlisayisi[Array.IndexOf(ortakdegiskenler.otobusadi.ToArray(), comboBox1.Text)]);
            butonlistesi = new Button[teklisayisi+ciftsayisi*2];
            toplambuton = 0;
            Array.Clear(butonlistesi, 0, butonlistesi.Length);

            int i = 0;
            int top = 75;
            int left = 425;

            do
            {
                Button btn_koltuktekli = new Button();
                btn_koltuktekli.Text = "C" + (i + 1);
                bikili = btn_koltuktekli.Text;
                btn_koltuktekli.Location = new Point(left, top * (i + 1));
                btn_koltuktekli.Tag = 1;
                btn_koltuktekli.Click += new EventHandler(btn_koltuktekli_Click);
                this.Controls.Add(btn_koltuktekli);
                butonlistesi[toplambuton] = btn_koltuktekli;
                toplambuton++;
                i++;
            } while (i < teklisayisi);

           // toplambuton--;
            int j = 0;
            int yukari = 75;
            int sol = 575;

            do
            {
                Button btn_koltukikili = new Button();
                btn_koltukikili.Text = "K" + (j + 1);
                bikili = btn_koltukikili.Text;
                btn_koltukikili.Location = new Point(sol, yukari * (j + 1));
                btn_koltukikili.Tag = 1;
                btn_koltukikili.Click += new EventHandler(btn_koltukikili_Click);
                this.Controls.Add(btn_koltukikili);
                butonlistesi[toplambuton] = btn_koltukikili;
                toplambuton++;
                j++;
            } while (j < ciftsayisi);

       //     toplambuton--;
            int k = 0;
            int soldan = 650;

            do
            {
                Button btn_koltukikili = new Button();
                btn_koltukikili.Text = "İC" + (k + 1);
                bikili = btn_koltukikili.Text;
                btn_koltukikili.Location = new Point(soldan, top * (k + 1));
                btn_koltukikili.Tag = 1;
                btn_koltukikili.Click += new EventHandler(btn_koltukikili_Click);
                this.Controls.Add(btn_koltukikili);
                butonlistesi[toplambuton] = btn_koltukikili;
                toplambuton++;
                k++;
            } while (k < ciftsayisi);
        }

        private void btn_koltuktekli_Click(object sender, EventArgs e)
        {
            Button btn_koltuktekli = (Button)sender;
            label15.Text = btn_koltuktekli.Text;
            label14.Text = btn_koltuktekli.Tag.ToString();
        }

        private void btn_koltukikili_Click(object sender, EventArgs e)
        {
            Button btn_koltukikili = (Button)sender;
            label15.Text = btn_koltukikili.Text;
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Thread.Sleep(1000);
            button1.Enabled = true;            

            if(txt_teklisayisi.Text == "")
            {
                MessageBox.Show("Tekli Koltuk Sayısı Boş Bırakılamaz");
            }

            else if (Convert.ToInt32(txt_ciftlisayisi.Text) >= 8)
            {
                MessageBox.Show("7den fazla koltuk olamaz");
            }
            else if (txt_ciftlisayisi.Text == "")
            {
                MessageBox.Show("Bu Alan Boş Bırakılamaz");
            }
            else if (Convert.ToInt32(txt_ciftlisayisi.Text) >= 8)
            {
                MessageBox.Show("Çiftli Koltuk Sayısı 7den Fazla Olamaz.");
            }
            else if (txt_nereden.Text == "")
            {
                MessageBox.Show("Nereden Gideceğiniz Boş Bırakılamaz");
            }
            else if (txt_nereye.Text == "")
            {
                MessageBox.Show("Nereye Gideceğiniz Boş Bırakılamaz");
            }
            else if (txt_teklifiyat.Text == "")
            {
                MessageBox.Show("Tekli Koltuk Fiyatı Boş Bırakılamaz");
            }
            else if (txt_ciftfiyat.Text == "")
            {
                MessageBox.Show("Çiftli Koltuk Fiyatı Boş Bırakılamaz");
            }
            else 
            {
                teklisayisi = Convert.ToInt32(txt_teklisayisi.Text);
                ciftsayisi = Convert.ToInt32(txt_ciftlisayisi.Text);
                int i = 0;
                int top = 75;
                int left = 425;

                do
                {
                    Button btn_koltuktekli = new Button();
                    btn_koltuktekli.Name = "btn_tek" + (i + 1); 
                    btn_koltuktekli.Text = "C" + (i + 1);                         
                    btn_koltuktekli.Location = new Point(left, top * (i + 1));                       
                   // btn_koltuktekli.Click += new EventHandler(butonbulma_Click);                                                         
                    this.Controls.Add(btn_koltuktekli);                                                          
                    i++;
                } while (i < teklisayisi);

                int j = 0;
                int yukari = 75;
                int sol = 575;

                do
                {
                    Button btn_koltukikili = new Button();
                    btn_koltukikili.Name = "btn_kcift" + (j + 1);
                    btn_koltukikili.Text = "K" + (j + 1);
                    btn_koltukikili.Location = new Point(sol, yukari * (j + 1));
                  //  btn_koltukikili.Click += new EventHandler(butonbulma_Click);
                    this.Controls.Add(btn_koltukikili);
                    j++;
                } while (j < ciftsayisi);

                int k = 0;
                int soldan = 650;

                do
                {
                    Button btn_koltukikili = new Button();
                    btn_koltukikili.Name = "btn_ccift" + (k + 1);
                    btn_koltukikili.Text = "İC" + (k + 1);
                    btn_koltukikili.Location = new Point(soldan, top * (k + 1));
                  //  btn_koltukikili.Click += new EventHandler(butonbulma_Click);
                    this.Controls.Add(btn_koltukikili);
                    k++;
                } while (k < ciftsayisi);
            }

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            
            File.AppendAllText("C:\\Users\\NERO\\Desktop\\c\\asansor\\asansor\\bin\\Debug\\otobusbilgileri.txt", Environment.NewLine + txt_otobusismi.Text + ";" + txt_teklisayisi.Text + ";" + txt_ciftlisayisi.Text + ";" + txt_nereden.Text + ";" + txt_nereye.Text + ";" + txt_teklifiyat.Text + ";" + txt_ciftfiyat.Text + ";" + date_kalkis.Text);
            txt_ciftfiyat.Clear();
            txt_ciftlisayisi.Clear();
            txt_nereden.Clear();
            txt_nereye.Clear();
            txt_teklisayisi.Clear();
            txt_teklifiyat.Clear();
            txt_otobusismi.Clear();
        }

       

        private void txt_teklisayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }

            else if ((int)e.KeyChar == 44)
            {
                e.Handled = false;
            }

            else
            {
                MessageBox.Show("LUTFEN SAYİ GİRİNİZ", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_ciftlisayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }

            else if ((int)e.KeyChar == 44)
            {
                e.Handled = false;
            }

            else
            {
                MessageBox.Show("LUTFEN SAYİ GİRİNİZ", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_teklifiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }

            else if ((int)e.KeyChar == 44)
            {
                e.Handled = false;
            }

            else
            {
                MessageBox.Show("LUTFEN SAYİ GİRİNİZ", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txt_ciftfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }

            else if ((int)e.KeyChar == 44)
            {
                e.Handled = false;
            }

            else
            {
                MessageBox.Show("LUTFEN SAYİ GİRİNİZ", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        int a = 0;
     

        
    }
}
