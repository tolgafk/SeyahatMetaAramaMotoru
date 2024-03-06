using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilLab_Final
{
    public partial class Form4 : Form
    {
        int firma_no;

        public Form4(int i)
        {
            InitializeComponent();
            firma_no = i - 1;
            int modlama;
            foreach (Vehicle arac in Vehicle.araclar)
            {
                modlama = arac.aracID % 100;
                modlama /= 10;
                if (modlama == firma_no)
                {
                    comboBox1.Items.Add(arac.aracID);
                    comboBox2.Items.Add(arac.aracID + "(G)");
                    comboBox2.Items.Add(arac.aracID + "(D)");
                    comboBox3.Items.Add(arac.aracID);
                }
            }
            comboBox4.Items.Add(1);
            comboBox4.Items.Add(2);
            comboBox4.Items.Add(3);
            comboBox4.Items.Add(4);
            comboBox4.Items.Add(5);
            comboBox4.Items.Add(6);
            comboBox5.Items.Add("Havayolu");
            comboBox5.Items.Add("Demiryolu");
            comboBox5.Items.Add("Karayolu");
            comboBox6.Items.Add("Havayolu");
            comboBox6.Items.Add("Demiryolu");
            comboBox6.Items.Add("Karayolu");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public void yaz(int firm)
        {
            firma_no = firm;
            firma_no += 95;
            label1.Text = Convert.ToChar(firm).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Firma.gunlukKar(firma_no);
            label3.Text = x.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            Firma.aracEkle(comboBox6.SelectedIndex.ToString(), id);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
