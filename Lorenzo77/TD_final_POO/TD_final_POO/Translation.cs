using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Translation
    {
        private string idElement;
        private string dx;
        private string dy;

        public Translation(string idElement, string dx, string dy)
        {
            this.idElement = idElement;
            this.dx = dx;
            this.dy = dy;
        }

        public string Dx
        {
            get { return dx; }
            set { dx = value; }
        }
        public string Dy
        {
            get { return dy; }
            set { dy = value; }
        }
    }
}
