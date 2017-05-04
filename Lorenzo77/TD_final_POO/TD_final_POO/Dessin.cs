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
                    try
                    {
                        string typeDeForme = temp[0];
                        Int32.TryParse(temp[1], out int idElement);
                        Int32.TryParse(temp[8], out int ordre);
                        Int32.TryParse(temp[5], out int R);
                        Int32.TryParse(temp[6], out int G);
                        Int32.TryParse(temp[7], out int B);
                        Int32.TryParse(temp[2], out int cx);
                        Int32.TryParse(temp[3], out int cy);
                        Int32.TryParse(temp[4], out int r);
                        Cercle cercle = new Cercle(typeDeForme, idElement, ordre, R, G, B, null, null, cx, cy, r);
                        list_form.Add(cercle);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Exception caught.", e);
                    }
                }

                if (temp[0] == "Ellipse")
                {
                    try
                    {
                        string typeDeForme = temp[0];
                        Int32.TryParse(temp[1], out int idElement);
                        Int32.TryParse(temp[9], out int ordre);
                        Int32.TryParse(temp[6], out int R);
                        Int32.TryParse(temp[7], out int G);
                        Int32.TryParse(temp[8], out int B);
                        Int32.TryParse(temp[2], out int cx);
                        Int32.TryParse(temp[3], out int cy);
                        Int32.TryParse(temp[4], out int rx);
                        Int32.TryParse(temp[5], out int ry);
                        Ellipse ellipse = new Ellipse(typeDeForme, idElement, ordre, R, G, B, null, null, cx, cy, rx, ry);
                        list_form.Add(ellipse);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Exception caught.", e);
                    }

                }

                if (temp[0] == "Rectangle")
                {
                    try
                    {
                        string typeDeForme = temp[0];
                        Int32.TryParse(temp[1], out int idElement);
                        Int32.TryParse(temp[9], out int ordre);
                        Int32.TryParse(temp[6], out int R);
                        Int32.TryParse(temp[7], out int G);
                        Int32.TryParse(temp[8], out int B);
                        Int32.TryParse(temp[2], out int x);
                        Int32.TryParse(temp[3], out int y);
                        Int32.TryParse(temp[4], out int largeur);
                        Int32.TryParse(temp[5], out int hauteur);
                        Rectangle rect = new Rectangle(typeDeForme, idElement, ordre, R, G, B, null, null, x, y, largeur, hauteur);
                        list_form.Add(rect);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Exception caught.", e);
                    }
                }

                if (temp[0] == "Polygone")
                {
                    try
                    {
                        string typeDeForme = temp[0];
                        Int32.TryParse(temp[1], out int idElement);
                        Int32.TryParse(temp[6], out int ordre);
                        Int32.TryParse(temp[3], out int R);
                        Int32.TryParse(temp[4], out int G);
                        Int32.TryParse(temp[5], out int B);
                        string points = temp[2];
                        Polygone poly = new Polygone(typeDeForme, idElement, ordre, null, null, R, G, B, points);
                        list_form.Add(poly);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Exception caught.", e);
                    }
                }

                if(temp[0] == "Chemin")
                {
                    try
                    {
                        string typeDeForme = temp[0];
                        Int32.TryParse(temp[1], out int idElement);
                        Int32.TryParse(temp[6], out int ordre);
                        Int32.TryParse(temp[3], out int R);
                        Int32.TryParse(temp[4], out int G);
                        Int32.TryParse(temp[5], out int B);
                        string path = temp[2];
                        Chemin chemin = new Chemin(typeDeForme, idElement, ordre, null, null, R, G, B, path);
                        list_form.Add(chemin);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Exception caught.", e);
                    }
                }

                if (temp[0] == "Texte")
                {
                    try
                    {
                        string typeDeForme = temp[0];
                        Int32.TryParse(temp[1], out int idElement);
                        Int32.TryParse(temp[8], out int ordre);
                        Int32.TryParse(temp[5], out int R);
                        Int32.TryParse(temp[6], out int G);
                        Int32.TryParse(temp[7], out int B);
                        Int32.TryParse(temp[2], out int x);
                        Int32.TryParse(temp[3], out int y);
                        string contenu = temp[4];
                        Texte text = new Texte(typeDeForme, idElement, ordre, null, null, R, G, B, x, y, contenu);
                        list_form.Add(text);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Exception caught.", e);
                    }
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
                        try
                        {
                            Int32.TryParse(temp[1], out int idElement);
                            if (idElement == elem.IDElement)
                            {
                                Int32.TryParse(temp[2], out int dx);
                                Int32.TryParse(temp[3], out int dy);

                                Translation trans = new Translation(idElement, dx, dy);
                                elem.Trans = trans;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("{0} Exception caught.", e);
                        }
                    }
                }

                if (temp[0] == "Rotation")
                {
                    foreach (Forme elem in list_form)
                    {
                        try
                        {
                            Int32.TryParse(temp[1], out int idElement);
                            if (idElement == elem.IDElement)
                            {
                                Int32.TryParse(temp[2], out int angle);
                                Int32.TryParse(temp[3], out int cx);
                                Int32.TryParse(temp[4], out int cy);
                                Rotation rot = new Rotation(idElement, angle, cx, cy);
                                elem.Rot = rot;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("{0} Exception caught.", e);
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
