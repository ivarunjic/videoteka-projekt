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
            
            string zanr = comboBox1.Text;
            List<string> Zanrovi = new List<string>() { };

            foreach (var film in popisFilmova)
            {
                if (film.Zanr.Contains(zanr))
                {
                    Zanrovi.Add(film.Naziv + " " + film.Godina + " " + film.Zanr);
                }
            }

            listBox1.DataSource = Zanrovi;

            if (comboBox1.Text == "Sve")
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

                    Zanrovi.Add(linija);
                    linija = sr.ReadLine();

                }
                sr.Close();
            }

            else { }


            /*for(int i = 0; i < popisFilmova.Count; i++)
            {
                if (popisFilmova[i].Zanr == zanr)
                {
                    Zanrovi.Add(popisFilmova[i].Naziv + " " + popisFilmova[i].Godina + " " + popisFilmova[i].Zanr);
                }

            }

            listBox1.DataSource=Zanrovi;*/

            /*private void ListFilmsByGenre(string zanr)
    {
        List<string> Zanrovi = new List<string>();*/

        
  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string min= "1970";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = textBox1.Text.Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(query))
            {
                var results = popisFilmova.Where(film => film.Naziv.ToLower().Contains(query) || film.Godina.ToLower().Contains(query) || film.Zanr.ToLower().Contains(query)).ToList();
                comboBox1(results);
            }
            else
            {
                MessageBox.Show("Molimo unesite tekst za pretragu!");
            }
        }
    }
}
