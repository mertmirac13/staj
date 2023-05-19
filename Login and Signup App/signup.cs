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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        string dosyayolu = Application.StartupPath + "\\kullanicibilgileri.txt";
        int yas;
        ortakdegiskenler degiskennesnesi = new ortakdegiskenler();        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan fark;
            DateTime dogumtarihi;
            dogumtarihi = Convert.ToDateTime(dateTimePicker1.Text);
            fark = DateTime.Now.Date.Subtract(dogumtarihi);
            yas = Convert.ToInt32(fark.TotalDays);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(yas/365);
            StreamReader sr = new StreamReader("kullanicibilgileri.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }
            sr.Close();
            if (ortakdegiskenler.kullanicilar.Contains(textBox1.Text) && ortakdegiskenler.sifreler.Contains(textBox2.Text) && Array.IndexOf(ortakdegiskenler.kullanicilar.ToArray(), textBox1.Text) == Array.IndexOf(ortakdegiskenler.sifreler.ToArray(), textBox2.Text))
            {
                MessageBox.Show("Kullanıcı Zaten Var.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("İsim Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(textBox2.Text == "")
            {
                MessageBox.Show("Şifre Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("Tekrar Şifre Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen Yetki Seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Lütfen Yönetici Seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ( yas/365 < 18)
            {
                MessageBox.Show("Yaşınız 18den Büyük Olmalı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox5.Text != "123")
            {
                MessageBox.Show("Hatalı Admin Şifresi , Ekleme Yapmak İçin Admin Olmalısınız!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox2.Text != textBox6.Text)
            {
                MessageBox.Show("Şifre ve Şifre Tekrar Aynı Olmalıdır, Lütfen Tekrar Deneyiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox5.Text == "123" &&  yas/365 >= 18  )
            {                           
                File.AppendAllText(dosyayolu , Environment.NewLine + textBox1.Text + ";" + textBox2.Text + ";" + textBox3.Text + ";" + textBox4.Text + ";" + comboBox1.Text + ";" + comboBox2.Text);
                this.Hide();
                Form5 secondform = new Form5();
                secondform.Show();                
            }          
        }      
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (!textBox2.Text.Any(char.IsUpper) && !textBox2.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Şifrenizde en az bir büyük harf ve rakam ZORUNLUDUR." , "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Text = "";
            }
            else if (!textBox2.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Şifrenizde en az bir rakam bulunmalı");
                textBox2.Text = "";

            }
            else if (!textBox2.Text.Any(char.IsUpper))
            {
                MessageBox.Show("Şifrenizde en az bir büyük harf bulunması ZORUNLUDUR.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Text = "";
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox6.PasswordChar = '\0';
            }
            else
            {
                textBox6.PasswordChar = '*';
            }
        }        
    }
}
