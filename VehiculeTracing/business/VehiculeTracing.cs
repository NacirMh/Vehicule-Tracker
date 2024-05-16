using SimalateurVehicule.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiculeTracing.business
{
    internal class VehiculeTracker
    {
        IDao dao;
        public  VehiculeTracker(IDao stock)
        {
            this.dao = stock;
        }
        private List<DTOstock> trace(int matricule , DateTime startDate , DateTime endDate)
        { 
            return dao.retrieve(matricule, startDate, endDate);
        }

        public void displaytrace(int matricule , DateTime startDate , DateTime endDate)
        {
            List<DTOstock> VehiculePosition = trace(matricule, startDate, endDate);
           
            foreach(var vp in VehiculePosition)
            {
                Console.WriteLine($"X : {vp.X} Y: {vp.Y} date : {vp.Time}");
            }
        }

    }
}
