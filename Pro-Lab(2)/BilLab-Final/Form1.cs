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
    public partial class Form1 : Form
    {
        Form9 sefer_ara = new Form9();
        Form2 yonetici_giris = new Form2();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sefer_ara.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yonetici_giris.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
