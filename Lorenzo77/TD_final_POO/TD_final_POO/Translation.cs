using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Translation
    {
        private int idElement;
        private int dx;
        private int dy;

        public Translation(int idElement, int dx, int dy)
        {
            this.idElement = idElement;
            this.dx = dx;
            this.dy = dy;
        }

        public int Dx
        {
            get { return dx; }
            set { dx = value; }
        }
        public int Dy
        {
            get { return dy; }
            set { dy = value; }
        }
    }
}
