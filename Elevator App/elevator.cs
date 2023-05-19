using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asansor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gitmekistenilenkat = 0;
        int asansornerede = 0;
        int gorevlistesi = 0;
        int sayac;
        bool timerbasladimi = false;
        int aktifgorev = 0;
        Button[] katlar;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            katlar = new Button[10] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10 };
        }
        Button oncekikat;
        List<int> firstlist = new List<int>();
        int gorevbitti = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {            
            if (gorevlistesi < firstlist.Count)
            {
                if (asansornerede < firstlist[gorevlistesi])
                {
                    if (oncekikat != null) oncekikat.BackColor = Color.Red;
                    katlar[asansornerede].BackColor = Color.Orange;
                    varislabel.Text = (Math.Abs(Convert.ToDouble(gitmekistenilenkat) - Convert.ToDouble(asansornerede))).ToString();
                    oncekikat = katlar[asansornerede];
                    asansornerede++;
                }
                else if (asansornerede > firstlist[gorevlistesi])
                {
                    if (oncekikat != null) oncekikat.BackColor = Color.Red;
                    katlar[asansornerede].BackColor = Color.Orange;
                    varislabel.Text = (Math.Abs(Convert.ToDouble(gitmekistenilenkat) - Convert.ToDouble(asansornerede))).ToString();
                    oncekikat = katlar[asansornerede];
                    asansornerede--;
                }
                else if (asansornerede == firstlist[gorevlistesi])
                {
                    if (oncekikat != null) oncekikat.BackColor = Color.Red;
                    varislabel.Text = (Math.Abs(Convert.ToDouble(gitmekistenilenkat) - Convert.ToDouble(asansornerede))).ToString();
                    katlar[asansornerede].BackColor = Color.Green;
                    sayac = 0;
                    gorevlistesi++;
                }
            }           
                if (sayac == 10 && asansornerede+1 <= 5)
                {
                    firstlist.Add(0);
                    aktifgorev++;
                }
                else if (sayac == 10 && asansornerede+1 > 5)
                {
                    firstlist.Add(9);
                    aktifgorev++;
                }                      
            sayac++;
        }
        bool tekrarbasilmadi = false;
        private void button11_Click(object sender, EventArgs e)
        {           
            if (firstlist.Count != 0)
            {
                if (firstlist[firstlist.Count - 1] == Convert.ToInt16(textBox1.Text)-1)
                {
                    MessageBox.Show("Zaten Bastınız", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tekrarbasilmadi = true;
                }
                else
                {
                    tekrarbasilmadi = false;
                }             
            }         
            if (!tekrarbasilmadi)
            {
                gitmekistenilenkat = Convert.ToInt16(textBox1.Text) - 1;
                
                if (timerbasladimi == false)
                {
                    timer1.Start();
                }
                firstlist.Add(Convert.ToInt16(textBox1.Text) - 1);
                aktifgorev++;
            }           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Convert.ToInt16(textBox1.Text) > 10)
                {
                    MessageBox.Show("10'dan büyük sayı giremezsiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }
            }                
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
            Secenekler secondform = new Secenekler();
            secondform.Show();
        }
    }
}
