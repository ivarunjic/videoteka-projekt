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
        public string naziv, godina, zanr;

        public Film(string naziv, string godina, string zanr)
        {
            this.naziv = naziv;
            this.godina = godina;
            this.zanr = zanr;
        }

        public Film(string unos)
        {
            string trenutno = "";
            int brojac = 0;
            int i;

            naziv = "Nije uneseno";
            godina = "Nije uneseno";
            zanr = "Nije uneseno";

            for(i = 0; i < unos.Length; i++)
            {
                if(unos[i] == ',' || i == unos.Length - 1 )
                {
                    if (brojac == 0)
                    {
                        naziv = trenutno;
                        brojac++;
                    }
                    else if (brojac == 1)
                    {
                        godina = trenutno;
                        brojac++;
                    }
                    else
                    {
                        trenutno += unos[i];
                        zanr = trenutno;
                    }

                    trenutno = "";
                }
                else trenutno += unos[i];
            }
        }

        /*

            for (i = 0; i < unos.Length; i++)
            {
                if (unos[i] == '|' || i == unos.Length - 1)
                {
                    if (brojac == 0)
                    {
                        ime = trenutno;
                        brojac++;
                    }
                    else if (brojac == 1)
                    {
                        prezime = trenutno;
                        brojac++;
                    }
                    else if (brojac == 2)
                    {
                        razred = trenutno;
                        brojac++;
                    }
                    else
                    {
                        trenutno += unos[i];
                        uspjeh = trenutno;
                    }

                    trenutno = "";
                }
                else trenutno += unos[i];
            }
        }*/
    }
}
