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

        public Rectangle(string typeDeForme, int idElement, int ordre, int R, int G, int B, Translation translation, Rotation rotation, int x, int y, int largeur, int hauteur) : base(typeDeForme, idElement, ordre, R, G, B, translation, rotation)
        {
            this.x = x;
            this.y = y;
            this.largeur = largeur;
            this.hauteur = hauteur;
        }

        public override string ToString()
        {
            if (Trans == null && Rot == null)
                return "<rect x=\"" + x + "\" y=\"" + y + "\" width=\"" + largeur + "\" height=\"" + hauteur + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\"/>";
            if (Trans == null && Rot != null)
                return "<rect x=\"" + x + "\" y=\"" + y + "\" width=\"" + largeur + "\" height=\"" + hauteur + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"rotate(" + Rot.Angle + " " + Rot.Cx + "," + Rot.Cy + ")\"/>";
            if (Trans != null && Rot == null)
                return "<rect x=\"" + x + "\" y=\"" + y + "\" width=\"" + largeur + "\" height=\"" + hauteur + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"translate(" + Trans.Dx + "," + Trans.Dy + ")\"/>";

            //si trans && rot non null
            return "<rect x=\"" + x + "\" y=\"" + y + "\" width=\"" + largeur + "\" height=\"" + hauteur + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"translate(" + Trans.Dx + "," + Trans.Dy + ") rotate(" + Rot.Angle + " " + Rot.Cx + "," + Rot.Cy + ")\"/>";
        }
    }
}
