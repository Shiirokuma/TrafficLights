﻿/*
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
    public class Pieton :  IUsager
    {
        private double _vitesse;

        public double Vitesse { get => _vitesse; set => _vitesse = value; }

        public Pieton()
        {
        }
        public Pieton(double vitesse)
        {
            Vitesse = vitesse;
        }

        public void Stopper()
        {

        }

        public void Accelerer()
        {
        }
    }
}