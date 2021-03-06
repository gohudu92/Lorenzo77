﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_final_POO
{
    class Forme : IComparable<Forme>
    {
        private string typeDeForme;
        private int idElement;
        private int ordre;
        private int R;
        private int G;
        private int B;
        private Translation translation;
        private Rotation rotation; 


        public Forme(string typeDeForme, int idElement, int ordre, int R, int G, int B, Translation translation, Rotation rotation)
        {
            this.typeDeForme = typeDeForme;
            this.idElement = idElement;
            this.ordre = ordre;

            //verification que les couleurs rgb sont bien comprises dans l'intervalle [0,255]
            if (R >= 0 && R <= 255)
                this.R = R;
            else if (R > 255)
                this.R = 255;

            if (G >= 0 && G <= 255)
                this.G = G;
            else if (G > 255)
                this.G = 255;

            if (B >= 0 && B <= 255)
                this.B = B;
            else if (B > 255)
                this.B = 255;

            this.translation = translation;
            this.rotation = rotation;
        }
         
        //on met un accesseur sur ces attributs car on en a besoin dans le ToString() de toutes les formes specifiques 
        public int Red { get { return R; } }
        public int Green { get { return G; } }
        public int Blue { get { return B; } }
        public int IDElement { get { return idElement; } }

        //les objets translation et rotation ont egalement un set car 
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

        public int CompareTo(Forme other)
        {
            if (ordre == other.ordre)
                return 0;
            else if (ordre > other.ordre)
                return 1;
            else
                return -1; 
        }
    }
}
