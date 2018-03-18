using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validador va = new Validador();
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            string d = textBox4.Text;

            int val = 0;
            int inval = 0;

            if (va.esEntero(a) == true)
            {
                val++;
            }
            else
            {
                inval++;
            }
            if (va.esDecimal(b) == true)
            {
                val++;
            }
            else
            {
                inval++;
            }

            if (va.esEdad(c) == true)
            {
                val++;
            }
            else
            {
                inval++;
            }
            if (va.esDigito(d) == true)
            {
                val++;
            }
            else
            {
                inval++;
            }
            MessageBox.Show("Válidos:\t" + val + "\nIválidos:\t" + inval);
        }
    }
}
