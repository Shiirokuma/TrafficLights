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
        List<Vehicule> vehicules;

        [TestInitialize]
        public void InitialisationListVehicules()
        {
            vehicules = new List<Vehicule> {
            new Velo(),
            new Voiture(),
            new Tram(),
            new Moto(),
            new Camion(),
            new Bus()
            };
        }

        [TestMethod]
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

        [TestMethod]
        public void CheckIfBusIsStoppedSpeedShouldBe0()
        {
            ArretTPG arret = new ArretTPG();
            Bus bus21 = new Bus();
            arret.ArretBus(bus21);
            Assert.AreEqual(0, bus21.Vitesse);
        }

        [TestMethod]
        public void CheckIfBusIsGoneSpeedShouldNotBe0()
        {
            ArretTPG arret = new ArretTPG();
            Bus bus21 = new Bus();
            arret.ArretBus(bus21);
            Assert.AreNotEqual(0, bus21.Vitesse);
        }

        [TestMethod]
        public void CheckIfFeuxChangeColorShouldBeRed()
        {
            bool testFeux = false;
            Feux feux = new Feux("Voiture", testFeux);
            feux.ChangemantDEtat();
            Assert.AreNotEqual(testFeux, feux.Etat);
        }

        #region Routes
        [TestMethod]
        public void CheckIfRoutesDirectionIsNotNull()
        {
            Routes route = new Routes(0, "route de chancy");
            Assert.AreNotEqual(null, route.Direction);
        }

        [TestMethod]
        public void CheckIfRoutesNomIsNotNull()
        {
            Routes route = new Routes(0, "route de chancy");
            Assert.AreNotEqual(null, route.Nom);
        }
        #endregion

        #region Vehicules
        [TestMethod]
        public void CheckIfVehiculesTailleIsNotNull()
        {
            Routes route = new Routes(0, "route de chancy");
            Assert.AreNotEqual(null, route.Direction);
        }
        #endregion
        [TestCleanup]
        public void CleanListVehicules()
        {
            vehicules = null;
        }
    }
}