using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicações_Matematicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnumtab.Clear();
            lsttab.Items.Clear();
            txtnumtab.Focus();
        }

        private void btncaltab_Click(object sender, EventArgs e)
        {

            int num, c;
            try { 
            num = Convert.ToInt32(txtnumtab.Text);
            lsttab.Items.Clear();
            for (c = 1; c <= 10; c++)
            {
                lsttab.Items.Add(num + " x " + c + " = " + (num * c));
            }
            }   
            catch
            {
                MessageBox.Show("Favor,Coloque um número valido");
            }
        }
    }
}
