/*
* Groupe      : Groupe4
* Membres     : Martig Joey, Lorentz Florian, Calunsag Iya Katherine
* Programme   : Traffic Light
* Description : Créer un simulation réaliste du carrefour des esserts
* Version     : 1.0.0 
* Date        : 21.01.2019
*/
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficLightsGroupe4;

namespace UnitTestTrafficLights
{
    [TestClass]
    public class TDDTrafficLights
    {
        List<Vehicules> vehicules;

        [TestInitialize]
        public void InitialisationListVehicules()
        {
            vehicules = new List<Vehicules> {
            new Velo(),
            new Voiture(),
            new Tram(),
            new Moto(),
            new Camion()
            };
        }
        public void CheckAccelerer()
        {
            foreach (var item in vehicules)
            {
                double oldSpeed = item.Vitesse;
                item.Accelerer();
                Assert.AreNotEqual(oldSpeed, item.Vitesse);
            }
        }

        [TestMethod]
        public void CheckFreiner()
        {
            foreach (var item in vehicules)
            {
                double oldSpeed = item.Vitesse;
                item.Freiner();
                Assert.AreNotEqual(oldSpeed, item.Vitesse);
            }
        }

        [TestCleanup]
        public void CleanListVehicules()
        {
            vehicules = null;
        }
    }
}
