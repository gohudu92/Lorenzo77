using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Dessin
    {


        static List<Forme> lectureCSV(string nom_fichier)
        {
            List<Forme> list_form = new List<Forme>();

            // Ouverture du fichier, 
            StreamReader monStreamReader = new StreamReader(nom_fichier);

            // Lire la première ligne
            string ligne = monStreamReader.ReadLine();

            // Tant que la ligne lue n'est pas null
            while (ligne != null)
            {
                // Découper selon le séparateur ',', résultat: un tableau.
                string[] temp = ligne.Split(';');

                if (temp[0] == "Cercle")
                {
                    Cercle cercle = new Cercle(temp[0], temp[1], temp[8], temp[5], temp[6], temp[7], temp[2], temp[3], temp[4]);
                    list_form.Add(cercle); 
                }

                if (temp[0] == "Ellipse")
                {
                    Ellipse ellipse = new Ellipse(temp[0], temp[1], temp[9], temp[6], temp[7], temp[8], temp[2], temp[3], temp[4], temp[5]);
                    list_form.Add(ellipse);
                }

                if (temp[0] == "Rectangle")
                {
                    Rectangle rect = new Rectangle(temp[0], temp[1], temp[9], temp[6], temp[7], temp[8], temp[2], temp[3], temp[4], temp[5]);
                    list_form.Add(rect);
                }

                if (temp[0] == "Polygone")
                {
                    Polygone poly = new Polygone(temp[0], temp[1], temp[6], temp[3], temp[4], temp[5], temp[2]);
                    list_form.Add(poly); 
                }

                if(temp[0] == "Chemin")
                {
                    Chemin chemin = new Chemin(temp[0], temp[1], temp[6], temp[3], temp[4], temp[5], temp[2]);
                    list_form.Add(chemin);
                }

                if (temp[0] == "Texte")
                {
                    Texte text = new Texte(temp[0], temp[1], temp[8], temp[5], temp[6], temp[7], temp[2], temp[3], temp[4]);
                    list_form.Add(text);
                }
            
                // lire ligne suivante.
                ligne = monStreamReader.ReadLine();
            }


            // Fermeture du StreamReader (attention indispensable) 
            monStreamReader.Close();



            return list_form;
        }
    }
}
