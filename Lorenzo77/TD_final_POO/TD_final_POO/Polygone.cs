using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Polygone : Forme
    {
        private string points;

        public Polygone(string typeDeForme, int idElement, int ordre, Translation translation, Rotation rotation, int R, int G, int B, string points) : base(typeDeForme, idElement, ordre, R, G, B, translation, rotation)
        {
            this.points = points; 
        }

        public override string ToString()
        {
            if (Trans == null && Rot == null)
                return "<polygon points=\"" + points + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\"/>";
            if (Trans == null && Rot != null)
                return "<polygon points=\"" + points + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"rotate(" + Rot.Angle + " " + Rot.Cx + "," + Rot.Cy + ")\"/>";
            if (Trans != null && Rot == null)
                return "<polygon points=\"" + points + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"translate(" + Trans.Dx + "," + Trans.Dy + ")\"/>";

            //si trans && rot non null
            return "<polygon points=\"" + points + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"translate(" + Trans.Dx + "," + Trans.Dy + ") rotate(" + Rot.Angle + " " + Rot.Cx + "," + Rot.Cy + ")\"/>";

        }
    }
}
