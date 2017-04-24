using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Chemin : Forme
    {
        private string path;

        public Chemin(string typeDeForme, string idElement, string ordre, string R, string G, string B, string path) : base(typeDeForme, idElement, ordre, R, G, B)
        {
            this.path = path;
        }

        public override string ToString()
        {
            return "<path d=\"" + path + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" />";
        }
    }
}
