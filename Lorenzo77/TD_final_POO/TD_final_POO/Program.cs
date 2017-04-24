using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Dessin dessin = new Dessin();
            List<Forme> list_form = dessin.lectureCSV("ExempleTout.csv");
            dessin.lire_list(list_form); 
            Console.ReadKey(); 
        }
    }
}
