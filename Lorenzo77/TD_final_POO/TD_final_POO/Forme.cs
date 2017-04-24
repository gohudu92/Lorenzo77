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
        private int idElement;
        private int ordre;
        private int R;
        private int G;
        private int B;

        public Forme(string typeDeForme, int idElement, int ordre, int R, int G, int B)
        {
            this.typeDeForme = typeDeForme;
            this.idElement = idElement;
            this.ordre = ordre;
            this.R = R;
            this.G = G;
            this.B = B;
        }
    }
}
