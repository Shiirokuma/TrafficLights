/*
* Groupe      : Groupe4
* Membres     : Martig Joey, Lorentz Florian, Calunsag Iya Katherine
* Programme   : Traffic Light
* Description : Créer un simulation réaliste du carrefour des esserts
* Version     : 1.0.0 
* Date de création   : 21.01.2019
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightsGroupe4
{
    public abstract class Vehicule 
    {
        private int _roues;
        private int _directionImage;
        private double _taille;
        private double _vitesse;
        private double _posX;
        private double _posY;
        private string _immatriculation;
        private string _marque;
        private string _modele;
        private string _couleur;
        private string _pointDepart;
        private string _pointArrivee;
        private string _trajet;
        private string _image;
        public enum Type {
            NORMAL = 0,
            SIS = 1,
            TPG = 2
        };

        public int Roues { get => _roues; set => _roues = value; }
        public int DirectionImage { get => _directionImage; set => _directionImage = value; }
        public double Taille { get => _taille; set => _taille = value; }
        public double Vitesse { get => _vitesse; set => _vitesse = value; }
        public double PosX { get => _posX; set => _posX = value; }
        public double PosY { get => _posY; set => _posY = value; }
        public string Immatriculation { get => _immatriculation; set => _immatriculation = value; }
        public string Marque { get => _marque; set => _marque = value; }
        public string Modele { get => _modele; set => _modele = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }
        public string PointDepart { get => _pointDepart; set => _pointDepart = value; }
        public string PointArrivee { get => _pointArrivee; set => _pointArrivee = value; }
        public string Trajet { get => _trajet; set => _trajet = value; }
        public string Image { get => _image; set => _image = value; }

        public Type _type;

        public Vehicule(int roues, int directionImage, double taille, double vitesse, double posX, double posY, string immatriculation, string marque, string modele, string couleur, Type type, string pointDepart, string pointArrivee, string trajet, string image)
        {
            this.Roues = roues;
            this.DirectionImage = directionImage;
            this.Taille = taille;
            this.Vitesse = vitesse;
            this.PosX = posX;
            this.PosY = posY;
            this.Immatriculation = immatriculation;
            this.Marque = marque;
            this.Modele = modele;
            this.Couleur = couleur;
            this._type = type;
            this.PointDepart = pointDepart;
            this.PointArrivee = pointArrivee;
            this.Trajet = trajet;
            this.Image = image;
        }

        public Vehicule(double vitesse, double posX, double posY)
        {
            this.Vitesse = vitesse;
            this.PosX = posX;
            this.PosY = posY;

        }
       /* public double Accelerer()
        {
            double vitesse = this.Vitesse;
            for (int i = 50; i > this.Vitesse; i -= 10)
            {
                vitesse += 10;
            }
            this.Vitesse = vitesse;
            return this.Vitesse;
        }

        public double Freiner()
        {
            double vitesse = this.Vitesse;
            for (int i = 0; i < this.Vitesse; i += 10)
            {
                vitesse -= 10;
            }
            this.Vitesse = vitesse;
            return this.Vitesse;
        }*/
    }
}