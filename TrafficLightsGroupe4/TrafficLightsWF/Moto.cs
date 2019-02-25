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
    public class Moto : Vehicule
    {
        public Moto(int direction, double vitesse, int posX, int posY, PictureBox pcxImage, PictureBox pcxDetectCollision, bool collisionVehicle, bool collisionFeu) : base(direction, vitesse, posX, posY, pcxImage, pcxDetectCollision, collisionVehicle, collisionFeu)
        {

        }
    }
}
