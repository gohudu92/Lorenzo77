using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Rotation
    {
        private string idElement;
        private string angle; 
        private string cx;
        private string cy;

        public Rotation(string idElement, string angle, string cx, string cy)
        {
            this.idElement = idElement;
            this.angle = angle;
            this.cx = cx;
            this.cy = cy; 
        }

        public string Angle
        {
            get { return angle; }
            set { angle = value; }
        }
        public string Cx
        {
            get { return cx; }
            set { cx = value; }
        }
        public string Cy
        {
            get { return cy; }
            set { cy = value; }
        }
    }
}
