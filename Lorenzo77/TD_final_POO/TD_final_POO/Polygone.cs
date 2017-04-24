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

        public Polygone(string typeDeForme, string idElement, string ordre, string R, string G, string B, string points) : base(typeDeForme, idElement, ordre, R, G, B)
        {
            this.points = points; 
        }

        public override string ToString()
        {
            return "<polygon points=\"" + points + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" />";
        }
    }
}
