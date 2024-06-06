using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace videoteka
{
    public static class Admin
    {
       public static string FilePath = "PopisFilmova.txt";
        public static void SpremiUDatoteku(string Filmovi)
        {
            StreamWriter sw = new StreamWriter(Admin.FilePath, true);

          
            if (Filmovi != "")
            {
                sw.WriteLine(Filmovi);
               

                MessageBox.Show("Podaci o filmu su spremljeni!");
            }

            sw.Close();
        }

    }
}
