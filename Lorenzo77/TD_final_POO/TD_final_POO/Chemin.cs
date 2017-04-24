using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Chemin
    {
        private string path;

        public Chemin(string typeDeForme, int idElement, int ordre, int R, int G, int B, string path) : base(typeDeForme, idElement, ordre, R, G, B)
        {
            this.path = path;
        }
    }
}
