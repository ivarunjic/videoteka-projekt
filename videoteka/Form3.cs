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
        string stanjekombo = "";
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

            Console.WriteLine(popisFilmova[1].Zanr);
            Console.WriteLine(zanr);

            if (zanr != "Sve")
            {
                foreach (var film in popisFilmova)
                {
                    Console.WriteLine(film.Zanr);
                    if (film.Zanr.Contains(zanr))
                    {
                        Zanrovi.Add(film.Naziv + " " + film.Godina + " " + film.Zanr);
                    }
                }
            }
            else
            {

                foreach (var film in popisFilmova)
                {

                    Console.WriteLine(film.Zanr);
                    Zanrovi.Add(film.Naziv + " " + film.Godina + " " + film.Zanr);

                }

            }

            listBox1.DataSource = Zanrovi;
            stanjekombo = zanr;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string min = "1970";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = textBox1.Text.Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(query))
            {
                List<string> Zanrovi = new List<string>();
                var results = popisFilmova.Where(film => film.Naziv.ToLower().Contains(query) || film.Godina.Contains(query)).ToList();

                if (stanjekombo != "Sve" & stanjekombo != "")
                {
                    foreach (var film in results)
                    {
                        if (film.Zanr == stanjekombo)
                        {
                            Zanrovi.Add(film.Naziv + " " + film.Godina + " " + film.Zanr);
                        }
                    }
                }
                else
                {
                    foreach (var film in results)
                    {

                        Zanrovi.Add(film.Naziv + " " + film.Godina + " " + film.Zanr);

                    }

                }
                listBox1.DataSource = Zanrovi;


            }
            else
            {
                MessageBox.Show("Molimo unesite tekst za pretragu!");
            }
        }
    }
 }
