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

        public Chemin(string typeDeForme, string idElement, string ordre, Translation translation, Rotation rotation, string R, string G, string B, string path) : base(typeDeForme, idElement, ordre, R, G, B, translation, rotation)
        {
            this.path = path;
        }

        public override string ToString()
        {
            if (Trans == null && Rot == null)
                return "<path d=\"" + path + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\"/>";
            if (Trans == null && Rot != null)
                return "<path d=\"" + path + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"rotate(" + Rot.Angle + " " + Rot.Cx + "," + Rot.Cy + ")\"/>";
            if (Trans != null && Rot == null)
                return "<path d=\"" + path + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"translate(" + Trans.Dx + "," + Trans.Dy + ")\"/>";

            //si trans && rot non null
            return "<path d=\"" + path + "\" style=\"fill:rgb(" + Red + "," + Green + "," + Blue + ")\" transform=\"translate(" + Trans.Dx + "," + Trans.Dy + ") rotate(" + Rot.Angle + " " + Rot.Cx + "," + Rot.Cy + ")\"/>";

        }
    }
}
