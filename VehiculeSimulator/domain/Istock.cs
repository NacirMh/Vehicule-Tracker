using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimalateurVehicule.domain
{
    internal interface IDao
    {
        public bool stock(DTOstock s);
        public List<DTOstock> retrieve(int matricule, DateTime startDate, DateTime endDate);
    }
}
