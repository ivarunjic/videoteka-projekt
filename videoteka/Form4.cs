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

namespace videoteka
{
    public partial class Form4 : Form
    {
        string FilePath = "PopisFilmova.txt";
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* StreamWriter sw = new StreamWriter(filePath, true);
            string tekstUcenici;
            tekstUcenici = textBox1.Text + "|" + textBox2.Text + "|" + comboBox1.Text + "|" + comboBox2.Text ;
            if (tekstUcenici != "")
            {
                sw.WriteLine(tekstUcenici);
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                MessageBox.Show("Podaci su spremljeni!");

            }

            sw.Close();*/

            StreamWriter sw = new StreamWriter(FilePath, true);

            string Filmovi;
            Filmovi = textBox1.Text + "," +  comboBox1.Text + "," + checkedListBox1.Text + ",";

            if (Filmovi != "")
            {
                sw.WriteLine(Filmovi);
                textBox1.Text = "";
                comboBox1.Text = "";
                checkedListBox1.Text = "";

                MessageBox.Show("Podaci o filmu su spremljeni!");
            }

            sw.Close();

        }
    }
}
