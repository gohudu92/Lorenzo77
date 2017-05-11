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
            Dessin dessin = new Dessin("MM.csv"); //on crée un objet dessin qui prend en paramètre le fichier .csv
            dessin.CSVtoSVG(); //on convertit le CSV en SVG, le fichier .svg est créé automatiquement

            Console.ReadKey(); 
        }
    }
}
