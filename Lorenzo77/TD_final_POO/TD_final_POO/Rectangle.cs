using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Rectangle : Forme
    {
        private int x;
        private int y;
        private int largeur;
        private int hauteur;

        public Rectangle(string typeDeForme, int idElement, int ordre, int R, int G, int B, int x, int y, int largeur, int hauteur) : base(typeDeForme, idElement, ordre, R, G, B)
        {
            this.x = x;
            this.y = y;
            this.largeur = largeur;
            this.hauteur = hauteur;
        }
    }
}
