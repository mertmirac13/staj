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
using System.IO.Ports;
using System.Threading;

namespace asansor
{
    public partial class Proje4 : Form
    {
        public Proje4()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Secenekler secondform = new Secenekler();
            secondform.Show();
        }

        private void Proje4_Load(object sender, EventArgs e)
        {
            foreach (string item in System.IO.Ports.SerialPort.GetPortNames())
            {                
                comboBox1.Items.Add(item);
            }
            //arduino.BaudRate = 9600;
            //arduino.Open();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (true)
            {
                string a = arduino.ReadExisting();
                Console.WriteLine(a);
                Thread.Sleep(200);
            }

        }
        #region
        private void button3_Click(object sender, EventArgs e)
        {
            arduino.Write("1");
            button1.BackColor = Color.Green;
            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arduino.Write("0");
            button1.BackColor = Color.Red;
            button2.Enabled = true;
            button3.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            arduino.PortName = comboBox1.SelectedItem.ToString();
            arduino.Open();
        }

        private void Proje4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arduino.IsOpen) arduino.Close();
        }
        #endregion
    }
}
