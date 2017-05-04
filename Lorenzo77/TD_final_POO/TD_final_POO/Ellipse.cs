using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Ellipse : Forme
    {
        private int cx;
        private int cy;
        private int rx;
        private int ry;

        public Ellipse(string typeDeForme, int idElement, int ordre, int R, int G, int B, Translation translation, Rotation rotation, int cx, int cy, int rx, int ry) : base(typeDeForme, idElement, ordre, R, G, B, translation, rotation)
        {
            this.cx = cx;
            this.cy = cy;
            this.rx = rx;
            this.ry = ry; 
        }

        public override string ToString()
        {
            if (Trans == null && Rot == null)
                return "<ellipse cx=\"" + cx + "\" cy=\"" + cy + "\" rx=\"" + rx + "\" ry=\"" + ry + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\"/>";
            if (Trans == null && Rot != null)
                return "<ellipse cx=\"" + cx + "\" cy=\"" + cy + "\" rx=\"" + rx + "\" ry=\"" + ry + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"rotate(" + Rot.Angle + " " + Rot.Cx + "," + Rot.Cy + ")\"/>";
            if (Trans != null && Rot == null)
                return "<ellipse cx=\"" + cx + "\" cy=\"" + cy + "\" rx=\"" + rx + "\" ry=\"" + ry + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"translate(" + Trans.Dx + "," + Trans.Dy + ")\"/>";

            //si trans && rot non null
            return "<ellipse cx=\"" + cx + "\" cy=\"" + cy + "\" rx=\"" + rx + "\" ry=\"" + ry + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"translate(" + Trans.Dx + "," + Trans.Dy + ") rotate(" + Rot.Angle + " " + Rot.Cx + "," + Rot.Cy + ")\"/>";
        }


    }
}
