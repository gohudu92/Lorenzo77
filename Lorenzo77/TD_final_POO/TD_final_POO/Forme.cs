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
        private Translation translation;
        private Rotation rotation; 


        public Forme(string typeDeForme, string idElement, string ordre, string R, string G, string B, Translation translation, Rotation rotation)
        {
            this.typeDeForme = typeDeForme;
            this.idElement = idElement;
            this.ordre = ordre;
            this.R = R;
            this.G = G;
            this.B = B;
            this.translation = translation;
            this.rotation = rotation;
        }

        public string Red { get { return R; } }
        public string Green { get { return G; } }
        public string Blue { get { return B; } }
        public string IDElement { get { return idElement; } }
        public Translation Trans
        {
            get { return translation; }
            set { translation = value; }
        }
        public Rotation Rot
        {
            get { return rotation; }
            set { rotation = value; }
        }
    }
}
