using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Texte : Forme
    {
        private int x;
        private int y;
        private string content;

        public Texte(string typeDeForme, int idElement, int ordre, int R, int G, int B, int x, int y, string content) : base(typeDeForme, idElement, ordre, R, G, B)
        {
            this.x = x;
            this.y = y;
            this.content = content; 
        }
    }
}
