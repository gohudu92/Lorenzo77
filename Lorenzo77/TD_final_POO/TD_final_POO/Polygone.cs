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

        public Polygone(string typeDeForme, int idElement, int ordre, int R, int G, int B, string points) : base(typeDeForme, idElement, ordre, R, G, B)
        {
            this.points = points; 
        }
    }
}
