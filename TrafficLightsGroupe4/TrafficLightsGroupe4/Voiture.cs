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
    public class Voiture : Vehicule, IUsager
    {
        public Voiture(double vitesse, double posX, double posY): base(vitesse, posX, posY)
        {
            Vitesse = vitesse;
            PosX = posX;
            PosY = posY;
        }

        public Voiture(int roues, int directionImage, double taille, double vitesse, double posX, double posY, string immatriculation, string marque, string modele, string couleur, Type type, string pointDepart, string pointArrivee, string trajet, string image) : base(roues, directionImage, taille, vitesse, posX, posY, immatriculation, marque, modele, couleur, type, pointDepart, pointArrivee, trajet, image)
        {

        }
        public void Stopper()
        {
            PosX = PosX;
        }

        public void Accelerer()
        {
            PosX = PosX + Vitesse;
        }

    }
}