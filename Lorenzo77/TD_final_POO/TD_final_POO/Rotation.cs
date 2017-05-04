using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Rotation
    {
        private int idElement;
        private int angle; 
        private int cx;
        private int cy;

        public Rotation(int idElement, int angle, int cx, int cy)
        {
            this.idElement = idElement;
            this.angle = angle;
            this.cx = cx;
            this.cy = cy; 
        }

        public int Angle
        {
            get { return angle; }
            set { angle = value; }
        }
        public int Cx
        {
            get { return cx; }
            set { cx = value; }
        }
        public int Cy
        {
            get { return cy; }
            set { cy = value; }
        }
    }
}
