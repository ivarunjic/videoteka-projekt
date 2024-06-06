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
        string comboboxstanje = "";
        bool abecedno = false;
        bool brojcano = false;
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

            if (brojcano)
            {

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

            if (comboboxstanje != "Sve" & comboboxstanje != "")
            {
                foreach (var film in popisFilmova)
                {
                    if (film.Zanr == comboboxstanje)
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
            comboboxstanje = zanr;
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int izabrani = checkedListBox1.SelectedIndex;
            if (izabrani == 0)
            {

                abecedno = checkedListBox1.GetItemCheckState(izabrani) == CheckState.Checked;
                brojcano = false;
                checkedListBox1.SetItemCheckState(1, CheckState.Unchecked);
                Ispis();

            }
            else if (izabrani == 1)
            {

                brojcano = checkedListBox1.GetItemCheckState(izabrani) == CheckState.Checked;
                abecedno = false;
                checkedListBox1.SetItemCheckState(0, CheckState.Unchecked);
                Ispis();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = textBox1.Text.Trim().ToLower();
            pretraga = query;
            Ispis();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
   