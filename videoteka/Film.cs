using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace videoteka
{
    internal class Film
    {
        public string Naziv { get; set; }
        public string Godina { get; set; }
        public string Zanr { get; set; }

        public Film(string naziv, string godina, string zanr)
        {
            Naziv = naziv;
            Godina = godina;
            Zanr = zanr;
        }

        public Film(string unos)
        {
            string trenutno = "";
            int brojac = 0;
            int i;

            Naziv = "Nije uneseno";
            Godina = "Nije uneseno";
            Zanr = "Nije uneseno";

            for (i = 0; i < unos.Length; i++)
            {
                if (unos[i] == ',' || i == unos.Length - 1)
                {
                    if (brojac == 0)
                    {
                        Naziv = trenutno;
                        brojac++;
                    }
                    else if (brojac == 1)
                    {
                        Godina = trenutno;
                        brojac++;
                    }
                    else
                    {
                        if (i != unos.Length - 1)
                        {
                            trenutno += unos[i];
                        }
                        Zanr = trenutno;
                    }

                    trenutno = "";
                }
                else
                {
                    trenutno += unos[i];
                }
            }
        }

    }
}
