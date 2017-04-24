using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Rectangle : Forme
    {
        private string x;
        private string y;
        private string largeur;
        private string hauteur;

        public Rectangle(string typeDeForme, string idElement, string ordre, string R, string G, string B, string x, string y, string largeur, string hauteur) : base(typeDeForme, idElement, ordre, R, G, B)
        {
            this.x = x;
            this.y = y;
            this.largeur = largeur;
            this.hauteur = hauteur;
        }

        public override string ToString()
        {
            return "<rect x=\"" + x + "\" y=\"" + y + "\" width=\"" + largeur + "\" height=\"" + hauteur + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" />";
        }
    }
}
