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
       
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string str=textBox1.Text+","+comboBox1.Text+","+checkedListBox1.Text;
            Admin.SpremiUDatoteku(str);
            textBox1.Text = "";
            comboBox1.Text = "";
            checkedListBox1.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
