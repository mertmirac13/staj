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

namespace asansor
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Init_Data();
        }
        
        ortakdegiskenler degiskennesnesi = new ortakdegiskenler();

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("kullanicibilgileri.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(';');
                ortakdegiskenler.kullanicilar.Add(components[0]);
                ortakdegiskenler.sifreler.Add(components[1]);
                ortakdegiskenler.eposta.Add(components[2]);
                ortakdegiskenler.yaslar.Add(components[3]);
                ortakdegiskenler.yetkiler.Add(components[4]);
                ortakdegiskenler.yonetici.Add(components[5]);
            }
            sr.Close();
            
            if (ortakdegiskenler.kullanicilar.Contains(kullaniciadi.Text) && ortakdegiskenler.sifreler.Contains(sifre.Text) && Array.IndexOf(ortakdegiskenler.kullanicilar.ToArray(), kullaniciadi.Text) == Array.IndexOf(ortakdegiskenler.sifreler.ToArray(), sifre.Text))
            {
                Save_Data();
                ortakdegiskenler.yetki = Convert.ToInt32(ortakdegiskenler.yetkiler[Array.IndexOf(ortakdegiskenler.kullanicilar.ToArray(), kullaniciadi.Text)]);
                Secenekler secondform = new Secenekler();
                secondform.Show();
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }        
        private void Init_Data()
        {
            if(Properties.Settings.Default.UserName != String.Empty)
            {
                if(Properties.Settings.Default.Remember == true)
                {
                    kullaniciadi.Text = Properties.Settings.Default.UserName;
                    sifre.Text = Properties.Settings.Default.Password;
                    checkBox1.Checked = true;
                }
            }
            else
            {
                kullaniciadi.Text = Properties.Settings.Default.UserName;
            }
        }

        private void Save_Data()
        {
            if(checkBox1.Checked)
            {
                Properties.Settings.Default.UserName = kullaniciadi.Text;
                Properties.Settings.Default.Password = sifre.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }
        private void lbl_yenikullanici_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 secondform = new Form7();
            secondform.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            kullaniciadi.Text = "Ceren";
        }
    }                        
}                                                             
                                                                                 