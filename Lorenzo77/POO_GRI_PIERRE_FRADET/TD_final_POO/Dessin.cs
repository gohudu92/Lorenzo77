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
            //1ere lecture (on ne s'occupe pas des transformations et on retourne une liste de formes)
            List<Forme> list_form = lectureCSV();

            //2ème lecture (on s'occupe uniquement transformations et on modifie les formes contenues dans la liste)
            LectureTransformation(list_form);

            //on trie la liste selon l'attribut ordre
            list_form.Sort(); 

            //on transforme notre liste de formes en une chaine de caractère 
            string chaineSVG = listToString(list_form);

            //affichage dans la console (non nécessaire)
            Console.WriteLine(chaineSVG); 

            //on ecrit dans un fichier .svg le contenu de la chaine de caractère à l'interieur de <svg ...></svg>  
            EcrireSVG(chaineSVG);
        }

        public List<Forme> lectureCSV() //1ere lecture (on ne s'occupe pas des transformations et on retourne une liste de formes)
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
                        int idElement, ordre, R, G, B, cx, cy, r;
                        string typeDeForme = temp[0];
                        Int32.TryParse(temp[1], out idElement);
                        Int32.TryParse(temp[8], out ordre);
                        Int32.TryParse(temp[5], out R);
                        Int32.TryParse(temp[6], out G);
                        Int32.TryParse(temp[7], out B);
                        Int32.TryParse(temp[2], out cx);
                        Int32.TryParse(temp[3], out cy);
                        Int32.TryParse(temp[4], out r);
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
                        int idElement, ordre, R, G, B, cx, cy, rx, ry;
                        string typeDeForme = temp[0];
                        Int32.TryParse(temp[1], out idElement);
                        Int32.TryParse(temp[9], out ordre);
                        Int32.TryParse(temp[6], out R);
                        Int32.TryParse(temp[7], out G);
                        Int32.TryParse(temp[8], out B);
                        Int32.TryParse(temp[2], out cx);
                        Int32.TryParse(temp[3], out cy);
                        Int32.TryParse(temp[4], out rx);
                        Int32.TryParse(temp[5], out ry);
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
                        int idElement, ordre, R, G, B, x, y, largeur, hauteur;
                        string typeDeForme = temp[0];
                        Int32.TryParse(temp[1], out idElement);
                        Int32.TryParse(temp[9], out ordre);
                        Int32.TryParse(temp[6], out R);
                        Int32.TryParse(temp[7], out G);
                        Int32.TryParse(temp[8], out B);
                        Int32.TryParse(temp[2], out x);
                        Int32.TryParse(temp[3], out y);
                        Int32.TryParse(temp[4], out largeur);
                        Int32.TryParse(temp[5], out hauteur);
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
                        int idElement, ordre, R, G, B;
                        string typeDeForme = temp[0];
                        Int32.TryParse(temp[1], out idElement);
                        Int32.TryParse(temp[6], out ordre);
                        Int32.TryParse(temp[3], out R);
                        Int32.TryParse(temp[4], out G);
                        Int32.TryParse(temp[5], out B);
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
                        int idElement, ordre, R, G, B;
                        string typeDeForme = temp[0];
                        Int32.TryParse(temp[1], out idElement);
                        Int32.TryParse(temp[6], out ordre);
                        Int32.TryParse(temp[3], out R);
                        Int32.TryParse(temp[4], out G);
                        Int32.TryParse(temp[5], out B);
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
                        int idElement, ordre, R, G, B, x, y;
                        string typeDeForme = temp[0];
                        Int32.TryParse(temp[1], out idElement);
                        Int32.TryParse(temp[8], out ordre);
                        Int32.TryParse(temp[5], out R);
                        Int32.TryParse(temp[6], out G);
                        Int32.TryParse(temp[7], out B);
                        Int32.TryParse(temp[2], out x);
                        Int32.TryParse(temp[3], out y);
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

        public void LectureTransformation(List<Forme> list_form) //2ème lecture (on s'occupe uniquement transformations et on modifie les formes contenues dans la liste)
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
                            int idElement, dx, dy;
                            Int32.TryParse(temp[1], out idElement);
                            if (idElement == elem.IDElement)
                            {
                                Int32.TryParse(temp[2], out dx);
                                Int32.TryParse(temp[3], out dy);

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
                            int idElement, angle, cx, cy;
                            Int32.TryParse(temp[1], out idElement);
                            if (idElement == elem.IDElement)
                            {
                                Int32.TryParse(temp[2], out angle);
                                Int32.TryParse(temp[3], out cx);
                                Int32.TryParse(temp[4], out cy);
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

        //on ecrit dans un fichier .svg le contenu de la chaine de caractère à l'interieur de <svg ...></svg>  
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

        public string listToString(List<Forme> list) //on transforme notre liste de formes en une chaine de caractère 
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
