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

        public Ellipse(string typeDeForme, int idElement, int ordre, int R, int G, int B, int cx, int cy, int rx, int ry) : base(typeDeForme, idElement, ordre, R, G, B)
        {
            this.cx = cx;
            this.cy = cy;
            this.rx = rx;
            this.ry = ry; 
        }
    }
}
