using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Cercle : Forme
    {
        private int cx;
        private int cy;
        private int r;

        public Cercle(string typeDeForme, int idElement, int ordre, int R, int G, int B, Translation translation, Rotation rotation, int cx, int cy, int r) : base(typeDeForme, idElement, ordre, R, G, B, translation, rotation)
        {
            this.cx = cx;
            this.cy = cy;
            this.r = r; 
        }
        
        public override string ToString()
        {
            if(Trans == null && Rot == null)
                return "<circle cx=\"" + cx + "\" cy=\"" + cy + "\" r=\"" + r + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\"/>";
            if(Trans == null && Rot != null)
                return "<circle cx=\"" + cx + "\" cy=\"" + cy + "\" r=\"" + r + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"rotate(" + Rot.Angle + " " + Rot.Cx + "," + Rot.Cy + ")\"/>";
            if(Trans != null && Rot == null)
                return "<circle cx=\"" + cx + "\" cy=\"" + cy + "\" r=\"" + r + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"translate(" + Trans.Dx + "," + Trans.Dy + ")\"/>";
            
            //si trans && rot non null
            return "<circle cx=\"" + cx + "\" cy=\"" + cy + "\" r=\"" + r + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"translate(" + Trans.Dx + "," + Trans.Dy + ") rotate(" + Rot.Angle + " " + Rot.Cx + "," + Rot.Cy + ")\"/>";
        }

    }
}
