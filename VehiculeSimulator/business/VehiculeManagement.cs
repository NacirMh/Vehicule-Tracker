using SimalateurVehicule.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimalateurVehicule.business
{
    internal class VehiculeManagement
    {
        List<Vehicule> voitures ;
        IDao stock ;
        Mutex mutex = new Mutex();

        public VehiculeManagement(IDao stock)
        {
            this.voitures = new List<Vehicule>();
            this.stock = stock;
        }

        public void InitialiserVoiture(Vehicule v)
        {
            voitures.Add(v);

        }

        public void demarrerSimulateur()
        {
            
            foreach(Vehicule v in voitures)
            {
                Thread t = new Thread(() => demarrerGPS(v));
                t.Start();
            }

        }
        private void demarrerGPS(Vehicule v)
        {
            while(true)
            {
                Position p = new Position();
                DTOstock DTOstock = new DTOstock();
                DTOstock.X = p.X;
                DTOstock.Y = p.Y;
                DTOstock.Time = p.Timestamp;
                DTOstock.Matricule = v.Matricule;

                Console.WriteLine($"car : {v.Matricule} x : {p.X} y : {p.Y} time : {p.Timestamp} ");

                if (mutex.WaitOne())
                {
                    stock.stock(DTOstock);
                    mutex.ReleaseMutex();
                }
                System.Threading.Thread.Sleep(10000);

            }
        }


    }
}
