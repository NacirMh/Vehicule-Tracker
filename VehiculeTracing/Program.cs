using SimalateurVehicule.domain;
using SimalateurVehicule.Infrastructure;
using VehiculeTracing.business;


Console.WriteLine("enter the vehicule id: ");

int matricule = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the start date: ");

DateTime startdate = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("enter the end date: ");

DateTime enddate = Convert.ToDateTime(Console.ReadLine());

IDao dao = new DaoVPosition();

VehiculeTracker vehiculeTracker = new VehiculeTracker(dao);
Console.WriteLine($"Postions of vehicule {matricule} :");
vehiculeTracker.displaytrace(matricule, startdate, enddate);


