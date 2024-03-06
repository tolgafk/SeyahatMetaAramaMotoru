using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilLab_Final
{
    public partial class Form12 : Form
    {
        public Form12(int i, string b_indeks, string v_indeks)
        {
            InitializeComponent();
            if (i == 2) 
            { 
                panel3.Visible = true;
                label12.Text = Form11.list.ElementAt(1).name+ " " +Form11.list.ElementAt(1).surname;
            }
            label4.Text = Form11.list.ElementAt(0).name + " " + Form11.list.ElementAt(0).surname;
            label6.Text = b_indeks;
            label8.Text = v_indeks;
            Random random = new Random();
            string randomChars = "ABCDFXT1234567890";
            string ref_no = "X";
            for (i = 0; i < 5; i++)
            {
                ref_no += (randomChars[random.Next(randomChars.Length)]);
            }
            label3.Text = ref_no;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
