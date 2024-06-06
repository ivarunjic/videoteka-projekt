using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace videoteka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string UnosImena = "Djelatnik";
            string UnosSifre = "djelatnik123";

            if (textBox1.Text == UnosImena && textBox2.Text == UnosSifre)
            {
                Form4 newForm = new Form4();
                newForm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Krivo uneseni podaci. Pokušajte ponovo!");
            }

        }
    }
}
