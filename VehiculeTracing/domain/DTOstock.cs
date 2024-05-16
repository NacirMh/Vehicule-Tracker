using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimalateurVehicule.domain
{
    public class DTOstock
    {
        int matricule;
        int x;
        int y;
        DateTime time;

        public int Matricule { get => matricule; set => matricule = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public DateTime Time { get => time; set => time = value; }
    }
}
