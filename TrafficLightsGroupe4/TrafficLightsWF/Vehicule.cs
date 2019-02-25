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
using System.Windows.Forms;

namespace TrafficLightsWF
{
    public abstract class Vehicule
    {
        private int _direction;
        private double _vitesse;
        private int _posX;
        private int _posY;
        private bool _collisionVehicle;
        private bool _collisionFeu;
        private PictureBox _pcxImage;
        private PictureBox _pcxDetectCollision;

        public int Direction { get => _direction; set => _direction = value; }
        public double Vitesse { get => _vitesse; set => _vitesse = value; }
        public int PosX { get => _posX; set => _posX = value; }
        public int PosY { get => _posY; set => _posY = value; }
        public bool CollisionVehicle { get => _collisionVehicle; set => _collisionVehicle = value; }
        public bool CollisionFeu { get => _collisionFeu; set => _collisionFeu = value; }
        public PictureBox PcxImage { get => _pcxImage; set => _pcxImage = value; }
        public PictureBox PcxDetectCollision { get => _pcxDetectCollision; set => _pcxDetectCollision = value; }
        

        public Vehicule(int direction, double vitesse, int posX, int posY, PictureBox pcxImage, PictureBox pcxDetectCollision, bool collisionVehicle, bool collisionFeu)
        {
            this.Direction = direction;
            this.Vitesse = vitesse;
            this.PosX = posX;
            this.PosY = posY;
            this.PcxImage = pcxImage;
            this.PcxDetectCollision = pcxDetectCollision;
            this.CollisionVehicle = collisionVehicle;
            this.CollisionFeu = collisionFeu;
        }

        public void Avancer()
        {
            this.Vitesse = 30;
        }

        public void Freiner()
        {
            this.Vitesse = 0;
        }
    }
}
