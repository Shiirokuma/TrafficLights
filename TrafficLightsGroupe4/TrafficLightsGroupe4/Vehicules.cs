using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightsGroupe4
{
    public abstract class Vehicules
    {
        private int _roues;
        private double _taille;
        private double _vitesse;
        private string _immatriculation;
        private string _marque;
        private string _modele;
        private string _couleur;
        private string _type;
        private string _pointDepart;
        private string _pointArrivee;
        private string _trajet;

        public int Roues { get => _roues; set => _roues = value; }
        public double Taille { get => _taille; set => _taille = value; }
        public double Vitesse { get => _vitesse; set => _vitesse = value; }
        public string Immatriculation { get => _immatriculation; set => _immatriculation = value; }
        public string Marque { get => _marque; set => _marque = value; }
        public string Modele { get => _modele; set => _modele = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }
        public string Type { get => _type; set => _type = value; }
        public string PointDepart { get => _pointDepart; set => _pointDepart = value; }
        public string PointArrivee { get => _pointArrivee; set => _pointArrivee = value; }
        public string Trajet { get => _trajet; set => _trajet = value; }

        public Vehicules()
        {
            throw new NotImplementedException();
        }

        public double Accelerer()
        {
            throw new NotImplementedException();
        }

        public double Freiner()
        {
            throw new NotImplementedException();
        }
    }
}
