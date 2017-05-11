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

        public Texte(string typeDeForme, int idElement, int ordre, Translation translation, Rotation rotation, int R, int G, int B, int x, int y, string content) : base(typeDeForme, idElement, ordre, R, G, B, translation, rotation)
        {
            this.x = x;
            this.y = y;
            this.content = content; 
        }

        public override string ToString()
        {
            if (Trans == null && Rot == null)
                return "<text x=\"" + x + "\" y=\"" + y + "\" fill=\"rgb(" + Red + "," + Green + "," + Blue + ")\">" + content + "</text>";
            if (Trans == null && Rot != null)
                return "<text x=\"" + x + "\" y=\"" + y + "\" fill=\"rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"rotate(" + Rot.Angle + " " + Rot.Cx + "," + Rot.Cy + ")\">" + content + " </text>";
            if (Trans != null && Rot == null)
                return "<text x=\"" + x + "\" y=\"" + y + "\" fill=\"rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"translate(" + Trans.Dx + "," + Trans.Dy + ")\">" + content + "</text>";

            //si trans && rot non null
            return "<text x=\"" + x + "\" y=\"" + y + "\" fill=\"rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"translate(" + Trans.Dx + "," + Trans.Dy + ") rotate(" + Rot.Angle + " " + Rot.Cx + "," + Rot.Cy + ")\">" + content + "</text>";
        }
    }
}
