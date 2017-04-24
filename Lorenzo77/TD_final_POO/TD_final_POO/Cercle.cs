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

        public Cercle(string typeDeForme, int idElement, int ordre, int R, int G, int B, int cx, int cy, int r) : base(typeDeForme, idElement, ordre, R, G, B)
        {
            this.cx = cx;
            this.cy = cy;
            this.r = r; 
        }

        
    }
}
