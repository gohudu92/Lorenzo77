using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Texte : Forme
    {
        private string x;
        private string y;
        private string content;

        public Texte(string typeDeForme, string idElement, string ordre, string R, string G, string B, string x, string y, string content) : base(typeDeForme, idElement, ordre, R, G, B)
        {
            this.x = x;
            this.y = y;
            this.content = content; 
        }

        public override string ToString()
        {
            return "<text x=\"" + x + "\" y=\"" + y + "\" fill=\"rgb(" + Red + "," + Green + "," + Blue + ")\">" + content + "</text>";
        }
    }
}
