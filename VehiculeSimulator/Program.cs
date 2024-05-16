using SimalateurVehicule.business;
using SimalateurVehicule.domain;
using SimalateurVehicule.Infrastructure;

Vehicule v1 = new Vehicule();
Vehicule v2 = new Vehicule();
Vehicule v3 = new Vehicule();
v1.Matricule = 1;
v2.Matricule = 2;
v3.Matricule = 3;
IDao mysqlsave = new DaoVPosition();
VehiculeManagement gestionaire = new VehiculeManagement(mysqlsave);
gestionaire.InitialiserVoiture(v1);
gestionaire.InitialiserVoiture(v2);
gestionaire.InitialiserVoiture(v3);
gestionaire.demarrerSimulateur();