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
    public partial class Form3 : Form
    {
        Admin admin = new Admin();

        public Form3()
        {
            InitializeComponent();
            textBox1.Text = Admin.hizmet_bedeli.ToString();
            for (int i = 0; i < Firma.giris1.Count; i++)
            {
                comboBox1.Items.Add(Firma.giris1[i]);
                if (i == Firma.giris1.Count-1)
                {
                    break;
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int i))
            {
                Admin.hizmet_bedeli = i;
                textBox1.Text = Admin.hizmet_bedeli.ToString();
                label2.Text = "Hizmet bedeli değiştirildi!";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin.firma_sil(comboBox1.SelectedIndex);
            comboBox1.Items.Remove(comboBox1.SelectedIndex);
            label3.Text = "Firma silindi!";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!Firma.var_mi(textBox2.Text))
            {
                admin.firma_ekle(textBox2.Text, textBox3.Text);
                comboBox1.Items.Add(textBox2.Text);
                label6.Text = "Firma eklendi";
            }
            else
            {
                label6.Text = "Firma mevcut!";
            }
            
        }
    }
}
