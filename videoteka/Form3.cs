using System;
using System.Collections;
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
        bool abecedno = false;
        bool numericki = true;
        string pretraga = "";
        string FilePath = "PopisFilmova.txt";
        List<Film> popisFilmova = new List<Film>();
        List<Film> popisPocetni = new List<Film>();
        public Form3()
        {
            InitializeComponent();
        }

        private void Ispis()
        {
            popisFilmova = popisPocetni;

            if (numericki) {
                
                popisFilmova = popisFilmova.OrderBy(o => o.Godina).ToList();
            
            }
            else if (abecedno)
            {

                popisFilmova = popisFilmova.OrderBy(o => o.Naziv).ToList();

            }

            List<string> Zanrovi = new List<string>();

            if (!string.IsNullOrWhiteSpace(pretraga))
            {

                popisFilmova = popisFilmova.Where(film => film.Naziv.ToLower().Contains(pretraga) || film.Godina.Contains(pretraga)).ToList();

            }

            if (stanjekombo != "Sve" & stanjekombo != "")
            {
                foreach (var film in popisFilmova)
                {
                    if (film.Zanr == stanjekombo)
                    {
                        Zanrovi.Add(film.Naziv + " " + film.Godina + " " + film.Zanr);
                    }
                }
            }
            else
            {
                foreach (var film in popisFilmova)
                {
                    Zanrovi.Add(film.Naziv + " " + film.Godina + " " + film.Zanr);
                }
            }

            listBox1.DataSource = Zanrovi;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zanr = comboBox1.Text;
            stanjekombo = zanr;
            Ispis();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = textBox1.Text.Trim().ToLower();
            pretraga = query;
            Ispis();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(FilePath);
            string linija = sr.ReadLine();

            while (linija != null)
            {
                var razlomiti = new string[] { "," };
                popisPocetni.Add(new Film(linija));

                foreach (var c in razlomiti)
                {
                    linija = linija.Replace(c, " ");
                }

                linija = sr.ReadLine();
            }
            Ispis();
            sr.Close();
        }


    }
}
