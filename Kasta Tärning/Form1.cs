using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasta_Tärning
{
    public partial class Form1 : Form
    {

        Random rnd = new Random(); 
        int number = 0;
        int number1 = 0;
        int throws = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            number = (int)rnd.Next(1, 7);
            number1 = (int)rnd.Next(1, 7);

            label1.Text = number.ToString();
            label2.Text = number1.ToString();

            throws++;

            if (label1.Text == "6" && label2.Text == "6")
            {
                MessageBox.Show("Du har kastat " + throws.ToString() + " gånger, bra jobbat! :)");
            }
        }
    }
}
