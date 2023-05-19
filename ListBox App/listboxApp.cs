using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asansor
    
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        bool sirala = false;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Secenekler secondform = new Secenekler();
            secondform.Show();
        }
        private void btn_sayıat_Click(object sender, EventArgs e)
        {
            
             if (!sirala)
             {
                 sirala = true;
                 Random sayilar = new Random();
                 List<int> elemanlar = new List<int>();


                 for (int i = 0; i < 20; i++)
                 {
                     int sayi = sayilar.Next(1, 100);
                     listBox1.Items.Add(sayi);
                     elemanlar.Add(sayi);
                 }
             }
             else
             {
                 listBox1.Sorted = true;
             }
            
        }
        private void btn_hpsyolla_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Liste Boş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                }

                listBox1.Items.Clear();
            }

           
        }

        private void btn_yolla_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Liste Boş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (listBox1.SelectedItem == null)
                {
                    MessageBox.Show("LÜTFEN BİR SAYI SEÇİNİZ YA DA HEPSİNİ YOLLAYINIZ", "HATA", MessageBoxButtons.OK);
                }
                else
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
        }

        private void btn_gerial_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("Liste Boş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (listBox2.SelectedItem == null)
                {
                    MessageBox.Show("LÜTFEN BİR SAYI SEÇİNİZ YA DA HEPSİNİ YOLLAYINIZ", "HATA", MessageBoxButtons.OK);
                }
                else
                {
                    listBox1.Items.Add(listBox2.SelectedItem);
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }
        }

        private void btn_hpsgerial_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("Liste Boş", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                for (int j = 0; j < listBox2.Items.Count; j++)
                {
                    listBox1.Items.Add(listBox2.Items[j]);
                }

                listBox2.Items.Clear();
            }
        }
    }
}
