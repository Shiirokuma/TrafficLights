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
    public class Feu
    {
        private string _type;
        private bool _etat;
        private List<Vehicule> _traffic;
        private List<Pieton> _pieton;
        private double _posX;
        private double _posY;
        IUsager usager;

        List<IUsager> test = new List<IUsager>();

        public string Type { get => _type; set => _type = value; }
        public bool Etat { get => _etat; set => _etat = value; }
        public List<Vehicule> Traffic { get => _traffic; set => _traffic = value; }
        internal List<Pieton> Pieton { get => _pieton; set => _pieton = value; }
        public double PosX { get => _posX; set => _posX = value; }
        public double PosY { get => _posY; set => _posY = value; }

        /*public Feu() : this("voiture", true, 30, 10)
        {
        }*/

        public Feu()
        {

        }
        public Feu(string type, bool etat, double posX, double posY)
        {
            this.Type = type;
            this.Etat = etat;
            PosX = posX;
            PosY = posY;

        }
        public Feu(double posX, double posY)
        {
            PosX = posX;
            PosY = posY;

        }

        public void ChangemantDEtat()
        {
            Etat = !Etat;

            if (Etat == false)
            {
                test.Add(new Pieton());
                usager.Stopper();
                
            }
        }

    }
}
