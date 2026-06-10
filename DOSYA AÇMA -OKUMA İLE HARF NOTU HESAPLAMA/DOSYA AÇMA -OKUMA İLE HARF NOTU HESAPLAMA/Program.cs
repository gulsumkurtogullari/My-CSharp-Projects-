using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOSYA_AÇMA__OKUMA_İLE_HARF_NOTU_HESAPLAMA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] satirlar = File.ReadAllLines("C:\\Users\\EXCALIBUR\\OneDrive\\Desktop\\ogrencilerr.txt");
            StreamWriter sw = new StreamWriter("C:\\Users\\EXCALIBUR\\OneDrive\\Desktop\\harfnotları.txt");
            foreach (string satir in satirlar)
            {
                string[] p = satir.Split(';');

                string ad = p[0];
                int not = Convert.ToInt32(p[1]);

                string harf = "";
                if (not >= 85)
                {
                    harf = "AA";
                }
                else if (not >= 70)
                {
                    harf = "BB";
                }
                else if (not >= 60)
                {
                    harf = "CC";
                }
                else if (not >= 50)
                {
                    harf = "DD";
                }
                else
                {
                    harf = "FF";

                }

                sw.WriteLine(ad + "; " + harf);

            }
            sw.Close();
            Console.WriteLine("dosya oluşturuldu");
        }
    }
}
               

 