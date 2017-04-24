using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Forme
    {
        private string typeDeForme;
        private string idElement;
        private string ordre;
        private string R;
        private string G;
        private string B;

        public Forme(string typeDeForme, string idElement, string ordre, string R, string G, string B)
        {
            this.typeDeForme = typeDeForme;
            this.idElement = idElement;
            this.ordre = ordre;
            this.R = R;
            this.G = G;
            this.B = B;
        }

        public string Red { get { return R; } }
        public string Green { get { return G; } }
        public string Blue { get { return B; } }
        
    }
}
