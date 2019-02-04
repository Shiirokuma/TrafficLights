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
    public class ArretTPG
    {
        private string nomArret;

        public string NomArret { get => nomArret; set => nomArret = value; }


        public ArretTPG() : this("Les Essert")
        {

        }
        public ArretTPG(string nomArret)
        {
            this.NomArret = nomArret;
        }

        public void ArretBus(Bus bus)
        {
            // Arreter le bus
        }

        public void DepartBus(Bus bus)
        {
            // Faire démarrer le bus
        }
    }
}
