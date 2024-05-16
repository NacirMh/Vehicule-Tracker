using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimalateurVehicule.domain
{
    internal class Vehicule
    {
        private int matricule;
        private String fabrication;
        private String horseP;


        public int Matricule { 
            get => matricule; set => matricule = value;
        }
        public string Fabrication { 
            get => fabrication; set => fabrication = value;
        }
        public string HorseP { 
            get => horseP; set => horseP = value; 
        }
    }
}
