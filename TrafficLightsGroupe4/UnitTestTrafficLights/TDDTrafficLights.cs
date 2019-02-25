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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficLightsGroupe4;

namespace UnitTestTrafficLights
{
    [TestClass]
    public class TDDTrafficLights
    {
        //Instantiation d'une liste de vehicules
        List<Vehicule> vehicules;

        [TestInitialize]
        public void InitialisationListVehicules()
        {
            //Création des véhicules
            vehicules = new List<Vehicule> {
            new Velo(2,1,1,50,100,100,"5edfgt","La pierre", "e", "vert", Vehicule.Type.NORMAL, "essert", "essert", "essert", "C:\\"),
            new Voiture(2,1,1,50,100,100,"45252ffad","Porshe", "r", "rouge", Vehicule.Type.SIS, "essert", "essert", "essert", "C:\\"),
            new Tram(2,1,1,50,100,100,"rewqreqwr3","Mercedes", "t", "rose", Vehicule.Type.TPG, "essert", "essert", "essert", "C:\\"),
            new Moto(2,1,1,50,100,100,"fiodashf34","La pierre", "z", "jaune", Vehicule.Type.NORMAL, "essert", "essert", "essert", "C:\\"),
            new Camion(2,1,1,50,100,100,"erewrs543", "Volvo", "f", "noir", Vehicule.Type.NORMAL, "essert", "essert", "essert", "C:\\"),
            new Bus(2,1,1,50,100,100,"5423524daf","Mercedes", "v", "blanc", Vehicule.Type.TPG, "essert", "essert", "essert", "C:\\")
            };
        }

        #region Tests communs aux vehicules
        [TestMethod]
        public void CheckAccelerer()
        {
            foreach (var item in vehicules)
            {
                double oldSpeed = item.Vitesse;
                item.Accelerer();
                if (oldSpeed < item.Vitesse)
                {
                    Assert.AreNotEqual(oldSpeed, item.Vitesse);
                }
                else
                {
                    Assert.AreEqual(oldSpeed, item.Vitesse);
                }
            }
        }

        [TestMethod]
        public void CheckFreiner()
        {
            foreach (var item in vehicules)
            {
                double oldSpeed = item.Vitesse;
                item.Freiner();
                if (oldSpeed > item.Vitesse)
                {
                    Assert.AreNotEqual(oldSpeed, item.Vitesse);
                }
                else
                {
                    Assert.AreEqual(oldSpeed, item.Vitesse);
                }
            }
        }
        #endregion


        #region Bus / Tram
        [TestMethod]
        public void CheckIfBusIsStoppedSpeedShouldBe0()
        {
            ArretTPG arret = new ArretTPG();
            Bus bus21 = new Bus(2, 1, 1, 50, 100, 100, "5423524daf", "Mercedes", "v", "blanc", Vehicule.Type.TPG, "essert", "essert", "essert", "C:\\");
            arret.ArretBus(bus21);
            Assert.AreEqual(0, bus21.Vitesse);
        }

        [TestMethod]
        public void CheckIfBusIsGoneSpeedShouldNotBe0()
        {
            ArretTPG arret = new ArretTPG();
            Bus bus21 = new Bus(2, 1, 1, 50, 100, 100, "5423524daf", "Mercedes", "v", "blanc", Vehicule.Type.TPG, "essert", "essert", "essert", "C:\\");
            arret.ArretBus(bus21);
            Assert.AreNotEqual(0, bus21.Vitesse);
        }

        [TestMethod]
        public void CheckIfBusIsTPGShouldBeTPG()
        {
            Bus bus21 = new Bus(2, 1, 1, 50, 100, 100, "5423524daf", "Mercedes", "v", "blanc", Vehicule.Type.TPG, "essert", "essert", "essert", "C:\\");
            Assert.AreEqual(Vehicule.Type.TPG, bus21._type);
        }

        [TestMethod]
        public void CheckIfTramIsTPGShoulsBeTPG()
        {
            Tram tram14 = new Tram(20, 1, 40, 50, 100, 100, "dffdafkfkwe0", "Oue", "c", "Rose", Vehicule.Type.TPG, "essert", "essert", "essert", "C:\\");
            Assert.AreEqual(Vehicule.Type.TPG, tram14._type);
        }
        #endregion

        [TestMethod]
        public void CheckIfFeuxChangeColorShouldBeRed()
        {
            bool testFeux = false;
            Feu feux = new Feu("Voiture", testFeux);
            feux.ChangemantDEtat();
            Assert.AreNotEqual(testFeux, feux.Etat);
        }

        #region Routes
        [TestMethod]
        public void CheckIfRoutesDirectionIsNotNull()
        {
            Route route = new Route(0, "route de chancy");
            Assert.AreNotEqual(null, route.Direction);
        }

        [TestMethod]
        public void CheckIfRoutesNomIsNotNull()
        {
            Route route = new Route(0, "route de chancy");
            Assert.AreNotEqual(null, route.Nom);
        }
        #endregion

        #region Vehicules parametres is not null
        [TestMethod]
        public void CheckIfVehiculesRouesIsNotNull()
        {
            foreach (var item in vehicules)
            {
                Assert.AreNotEqual(null, item.Roues);
            }
        }

        [TestMethod]
        public void CheckIfVehiculesDirectionImageIsNotNull()
        {
            foreach (var item in vehicules)
            {
                Assert.AreNotEqual(null, item.DirectionImage);
            }
        }

        [TestMethod]
        public void CheckIfVehiculesTailleIsNotNull()
        {
            foreach (var item in vehicules)
            {
                Assert.AreNotEqual(null, item.Taille);
            }
        }

        [TestMethod]
        public void CheckIfVehiculesVitesseIsNotNull()
        {
            foreach (var item in vehicules)
            {
                Assert.AreNotEqual(null, item.Vitesse);
            }
        }

        [TestMethod]
        public void CheckIfVehiculesPosXIsNotNull()
        {
            foreach (var item in vehicules)
            {
                Assert.AreNotEqual(null, item.PosX);
            }
        }

        [TestMethod]
        public void CheckIfVehiculesPosYIsNotNull()
        {
            foreach (var item in vehicules)
            {
                Assert.AreNotEqual(null, item.PosY);
            }
        }

        [TestMethod]
        public void CheckIfVehiculesImmatriculationIsNotNull()
        {
            foreach (var item in vehicules)
            {
                Assert.AreNotEqual(null, item.Immatriculation);
            }
        }

        [TestMethod]
        public void CheckIfVehiculesMarqueIsNotNull()
        {
            foreach (var item in vehicules)
            {
                Assert.AreNotEqual(null, item.Marque);
            }
        }

        [TestMethod]
        public void CheckIfVehiculesModeleIsNotNull()
        {
            foreach (var item in vehicules)
            {
                Assert.AreNotEqual(null, item.Modele);
            }
        }

        [TestMethod]
        public void CheckIfVehiculesCouleurIsNotNull()
        {
            foreach (var item in vehicules)
            {
                Assert.AreNotEqual(null, item.Couleur);
            }
        }

        [TestMethod]
        public void CheckIfVehiculesTypeIsNotNull()

        {
            foreach (var item in vehicules)
            {
                Assert.AreNotEqual(null, item._type);
            }
        }

        [TestMethod]
        public void CheckIfVehiculesPointDepartIsNotNull()
        {
            foreach (var item in vehicules)
            {
                Assert.AreNotEqual(null, item.PointDepart);
            }
        }

        [TestMethod]
        public void CheckIfVehiculesPointArriveeIsNotNull()
        {
            foreach (var item in vehicules)
            {
                Assert.AreNotEqual(null, item.PointArrivee);
            }
        }

        [TestMethod]
        public void CheckIfVehiculesTrajetIsNotNull()
        {
            foreach (var item in vehicules)
            {
                Assert.AreNotEqual(null, item.Trajet);
            }
        }

        [TestMethod]
        public void CheckIfVehiculesImageIsNotNull()
        {
            foreach (var item in vehicules)
            {
                Assert.AreNotEqual(null, item.Image);
            }
        }
        #endregion

        [TestCleanup]
        public void CleanListVehicules()
        {
            vehicules = null;
        }
    }
}