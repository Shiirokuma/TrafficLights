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
    public class Bus : Vehicule, IArretTPG, IFeu
    {
        public Bus()
        {
                
        }
        public void Stopper()
        {

        }

        public void Accelerer()
        {
            // -> int speed = vitesse * 2 
        }

        public void StopperArret()
        {

        }

        public void AccelererArret()
        {
            // -> int speed = vitesse * 2 
        }
    }
}
