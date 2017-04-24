using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Cercle : Forme
    {
        private string cx;
        private string cy;
        private string r;

        public Cercle(string typeDeForme, string idElement, string ordre, string R, string G, string B, string cx, string cy, string r) : base(typeDeForme, idElement, ordre, R, G, B)
        {
            this.cx = cx;
            this.cy = cy;
            this.r = r; 
        }
        
        public override string ToString()
        {
            return "<circle cx=\"" + cx + "\" cy=\"" + cy + "\" r=\"" + r + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\"/>";
        }

    }
}
