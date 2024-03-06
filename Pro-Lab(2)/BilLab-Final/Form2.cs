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
    public partial class Form2 : Form
    {
        Firma firma = new Firma();
        Admin admin = new Admin();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check = 0;
            check=admin.Login(textBox1.Text, textBox2.Text);
            if (check == 1)
            {
                Form3 admin_panel = new();
                admin_panel.Show();
                this.Hide();
            }
            check = firma.Login(textBox1.Text, textBox2.Text);
            if(check != 0)
            {
                Form4 firma_panel = new Form4(check);
                firma_panel.Show();
                firma_panel.yaz(check);
                this.Hide();
            }
            if (check == 0) 
            {
                label4.Text = "Hatalı Giriş!!";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
