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
        private string nom_fichier;

        public Dessin(string nom_fichier)
        {
            this.nom_fichier = nom_fichier; 
        }

        public void CSVtoSVG()
        {
            List<Forme> list_form = lectureCSV();
            LectureTransformation(list_form);
            string chaineSVG = listToString(list_form);
            Console.WriteLine(chaineSVG);
            EcrireSVG(chaineSVG);
        }

        public List<Forme> lectureCSV()
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
                    Cercle cercle = new Cercle(temp[0], temp[1], temp[8], temp[5], temp[6], temp[7], null, null, temp[2], temp[3], temp[4]);
                    list_form.Add(cercle); 
                }

                if (temp[0] == "Ellipse")
                {
                    Ellipse ellipse = new Ellipse(temp[0], temp[1], temp[9], temp[6], temp[7], temp[8], null, null, temp[2], temp[3], temp[4], temp[5]);
                    list_form.Add(ellipse);
                }

                if (temp[0] == "Rectangle")
                {
                    Rectangle rect = new Rectangle(temp[0], temp[1], temp[9], temp[6], temp[7], temp[8], null, null, temp[2], temp[3], temp[4], temp[5]);
                    list_form.Add(rect);
                }

                if (temp[0] == "Polygone")
                {
                    Polygone poly = new Polygone(temp[0], temp[1], temp[6], null, null, temp[3], temp[4], temp[5], temp[2]);
                    list_form.Add(poly); 
                }

                if(temp[0] == "Chemin")
                {
                    Chemin chemin = new Chemin(temp[0], temp[1], temp[6], null, null, temp[3], temp[4], temp[5], temp[2]);
                    list_form.Add(chemin);
                }

                if (temp[0] == "Texte")
                {
                    Texte text = new Texte(temp[0], temp[1], temp[8], null, null, temp[5], temp[6], temp[7], temp[2], temp[3], temp[4]);
                    list_form.Add(text);
                }
            
                // lire ligne suivante.
                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader 
            monStreamReader.Close();

            return list_form;
        }

        public void LectureTransformation(List<Forme> list_form)
        {
            // Ouverture du fichier, 
            StreamReader monStreamReader = new StreamReader(nom_fichier);

            // Lire la première ligne
            string ligne = monStreamReader.ReadLine();

            // Tant que la ligne lue n'est pas null
            while (ligne != null)
            {
                // Découper selon le séparateur ',', résultat: un tableau.
                string[] temp = ligne.Split(';');

                if (temp[0] == "Translation")
                {
                    foreach(Forme elem in list_form)
                    {
                        if (temp[1] == elem.IDElement)
                        {
                            Translation trans = new Translation(temp[1], temp[2], temp[3]);
                            elem.Trans = trans; 
                        }
                    }
                }

                if (temp[0] == "Rotation")
                {
                    foreach (Forme elem in list_form)
                    {
                        if (temp[1] == elem.IDElement)
                        {
                            Rotation rot = new Rotation(temp[1], temp[2], temp[3], temp[4]);
                            elem.Rot = rot;
                        }
                    }
                }


                // lire ligne suivante.
                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader 
            monStreamReader.Close();
        }

        public void EcrireSVG(string chaineSVG)
        {
            string nom_fichier_svg = nom_fichier.Split('.')[0];
            nom_fichier_svg += ".svg"; 
            using (StreamWriter monStreamWriter = new StreamWriter(nom_fichier_svg))
            {
                monStreamWriter.WriteLine("<svg xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">");
                monStreamWriter.WriteLine(chaineSVG);
                monStreamWriter.WriteLine("</svg>");
            }
        }

        public string listToString(List<Forme> list)
        {
            string chaine ="";
            for (int i = 0; i < list.Count -1; i++) 
            {
                chaine += list[i] + "\n"; 
            }
            chaine += list[list.Count - 1]; 
            return chaine;     
        }

    }
}
