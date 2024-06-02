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
    public partial class Form3 : Form
    {
        string FilePath = "PopisFilmova.txt";
        List<Film> popisFilmova = new List<Film>();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(FilePath);
            string linija = sr.ReadLine();

            while (linija != null)
            {
                var razlomiti = new string[] { "," };
                popisFilmova.Add(new Film(linija));

                foreach (var c in razlomiti)
                {
                    linija = linija.Replace(c, " ");
                }

                listBox1.Items.Add(linija);
                linija = sr.ReadLine();

            }
            sr.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string razred = comboBox1.Text;
            List<string> Razredi = new List<string>() { };

            for (int i = 0; i < popisUcenika.Count; i++)
            {
                if (popisUcenika[i].razred == razred)
                {
                    Razredi.Add(popisUcenika[i].ime + " " + popisUcenika[i].prezime + " " + popisUcenika[i].razred + " " + popisUcenika[i].uspjeh);
                }
            }

            listBox1.DataSource = Razredi;
        }*/

            string zanr=comboBox1.Text;
            List<string> Zanrovi = new List<string>() { };

            for(int i = 0; i < popisFilmova.Count; i++)
            {
                if (popisFilmova[i].zanr == zanr)
                {
                    Zanrovi.Add(popisFilmova[i].naziv + " " + popisFilmova[i].godina + " " + popisFilmova[i].zanr + " ");
                }
            }

            listBox1.DataSource=Zanrovi;
        }
    }
}
