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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string[] binis = new string[20];
        string[] inis = new string[20];
        int teklisayisi;
        int ciftsayisi;
        Button[] butonlistesi;
        int toplambuton = 0;
        string btek;
        string bikili;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Secenekler secondform = new Secenekler();
            secondform.Show();
        }

        private void btn_otobusugetir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 secondform = new Form3();
            secondform.Show();
            File.AppendAllText("yolcubilgileribilgileri.txt", Environment.NewLine + txt_adsoyad.Text + ";" + cmb_cinsiyet.Text + ";" + cmb_nereden.Text + ";" + cmb_nereye.Text + ";" + dateTimePicker1.Text);

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
     
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("otobusbilgileri.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(';');
                ortakdegiskenler.otobusadi.Add(components[0]);
                ortakdegiskenler.teklisayisi.Add(components[1]);
                ortakdegiskenler.ciftlisayisi.Add(components[2]);
                ortakdegiskenler.nereden.Add(components[3]);
                ortakdegiskenler.nereye.Add(components[4]);
                //ortakdegiskenler.teklifiyati.Add(components[5]);
                //ortakdegiskenler.ciftfiyati.Add(components[6]);
                //ortakdegiskenler.kalkistarihi.Add(components[7]);
            }
            sr.Close();

            binis = ortakdegiskenler.nereden.ToArray();
            ortakdegiskenler.nereden.ToArray();
            cmb_nereden.Items.AddRange(binis);
        }
    }
}

