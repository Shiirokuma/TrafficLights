using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLightsGroupe4;

namespace TrafficLightsWF
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }
        int compteurFeu = 0;

        Vehicule car1;
        PictureBox pcxDCCar1 = new PictureBox();
        Vehicule car2;
        PictureBox pcxDCCar2 = new PictureBox();
        Vehicule car3;
        PictureBox pcxDCCar3 = new PictureBox();
        Vehicule car4;
        PictureBox pcxDCCar4 = new PictureBox();
        Vehicule bus1;
        PictureBox pcxDCBus1 = new PictureBox();
        Vehicule moto1;
        PictureBox pcxDCMoto1 = new PictureBox();

        Feu Feu;
        Feu Feu2;
        Feu Feu3;
        Feu Feu4;
        Image feuVert = Properties.Resources.FeuVert;
        Image feuRouge = Properties.Resources.FeuRouge;

        List<PictureBox> roadList;
        List<Feu> feuList;
        List<Vehicule> vehicleList;

        public void Main_Load(object sender, EventArgs e)
        {
            pcbCarrfour.SendToBack();
            Feu = new Feu("normal", true, pcbWhiteStrip, pcbFeu);
            Feu2 = new Feu("normal", true, pcbWhiteStrip2, pcbFeu2);
            Feu3 = new Feu("normal", false, pcbWhiteStrip3, pcbFeu3);
            Feu4 = new Feu("normal", false, pcbWhiteStrip4, pcbFeu4);
            roadList = new List<PictureBox>();
            vehicleList = new List<Vehicule>();
            feuList = new List<Feu>();
            Image imgRotate = pcbRoadBottom.Image;

            feuList.Add(Feu);
            feuList.Add(Feu2);
            feuList.Add(Feu3);
            feuList.Add(Feu4);

            roadList.Add(pcbRoadBottom);
            roadList.Add(pcbRoadLeft);
            roadList.Add(pcbRoadTop);
            roadList.Add(pcbRoadRight);

            // Rotation des images de routes
            imgRotate.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pcbRoadBottom.Image = imgRotate;
            imgRotate = pcbRoadTop.Image;
            imgRotate.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pcbRoadTop.Image = imgRotate;
            imgRotate = pcxBus1.Image;
            imgRotate.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pcxBus1.Image = imgRotate;

            // Création d'une voiture à la bonne place
            car1 = new Voiture(0, 0, pcbCar.Left, pcbCar.Top, pcbCar, pcxDCCar1, false, false);
            car2 = new Voiture(180, 0, pcbCar2.Left, pcbCar2.Top, pcbCar2, pcxDCCar2, false, false);
            car3 = new Voiture(90, 0, pcbCar3.Left, pcbCar3.Top, pcbCar3, pcxDCCar3, false, false);
            car4 = new Voiture(270, 0, pcbCar4.Left, pcbCar4.Top, pcbCar4, pcxDCCar4, false, false);
            bus1 = new Bus(0, 0, pcxBus1.Left, pcxBus1.Top, pcxBus1, pcxDCBus1, false, false);
            //moto1 = new Moto(270, 0, pcbCar4.Left, pcbCar4.Top, pcbCar4);

            vehicleList.Add(car1);
            vehicleList.Add(car2);
            vehicleList.Add(car3);
            vehicleList.Add(car4);
            vehicleList.Add(bus1);
            
            foreach (var car in vehicleList)
            {
                car.PcxDetectCollision.BackColor = Color.Red;
                Controls.Add(car.PcxDetectCollision);
                car.Avancer();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var feu in feuList)
            {
                if (feu.Etat)
                {
                    feu.PcxFeu.Image = feuVert;
                }
                else
                {
                    feu.PcxFeu.Image = feuRouge;
                }
            }

            foreach (var car in vehicleList)
            {
                if (car.CollisionFeu == true || car.CollisionVehicle == true)
                {
                    car.Freiner();
                }
                else
                {
                    car.Avancer();
                }
                HitBoxFeu(car);
                HitBoxVehicle(car);
                if (car.Vitesse > 0)
                {
                    ControlVehicule(car);
                }
                if (car.PosX < -20)
                {
                    car.PosX = 833;
                }
                if (car.PosY < -20)
                {
                    car.PosY = 510;
                }
                if (car.PosX > 833)
                {
                    car.PosX = -20;
                }
                if (car.PosY > 520)
                {
                    car.PosY = -20;
                }
            }
        }

        private void ControlVehicule(Vehicule car)
        {
            switch (car.Direction)
            {
                case 0:
                    car.PosY -= 2;
                    car.PcxDetectCollision.Size = new Size(car.PcxImage.Width, 25);
                    car.PcxDetectCollision.Left = car.PcxImage.Left;
                    car.PcxDetectCollision.Top = car.PcxImage.Top - car.PcxDetectCollision.Height;
                    break;
                case 90:
                    car.PosX += 2;
                    car.PcxDetectCollision.Size = new Size(25, car.PcxImage.Height);
                    car.PcxDetectCollision.Left = car.PcxImage.Right;
                    car.PcxDetectCollision.Top = car.PcxImage.Top;
                    break;
                case 180:
                    car.PosY += 2;
                    car.PcxDetectCollision.Size = new Size(car.PcxImage.Width, 25);
                    car.PcxDetectCollision.Left = car.PcxImage.Left;
                    car.PcxDetectCollision.Top = car.PcxImage.Bottom;
                    break;
                case 270:
                    car.PosX -= 2;
                    car.PcxDetectCollision.Size = new Size(25, car.PcxImage.Height);
                    car.PcxDetectCollision.Left = car.PcxImage.Left - car.PcxDetectCollision.Width;
                    car.PcxDetectCollision.Top = car.PcxImage.Top;
                    break;
            }
            car.PcxImage.Top = (int)car.PosY;
            car.PcxImage.Left = (int)car.PosX;
        }
        private string HitBoxRoad(Vehicule vehicle)
        {
            foreach (var road in roadList)
            {
                if (vehicle.PcxDetectCollision.Bounds.IntersectsWith(road.Bounds))
                {
                    return road.Name;
                }
            }
            return "";
        }

        private void HitBoxVehicle(Vehicule vehicle)
        {
            foreach (var vehicleInList in vehicleList)
            {
                if (vehicle.PcxDetectCollision.Bounds.IntersectsWith(vehicleInList.PcxImage.Bounds) && vehicle != vehicleInList)
                {
                    vehicle.CollisionVehicle = true;
                }
                else
                {
                    vehicle.CollisionVehicle = false;
                }
            }
        }
        private void HitBoxFeu(Vehicule vehicle)
        {
            foreach (var feu in feuList)
            {
                if (vehicle.PcxDetectCollision.Bounds.IntersectsWith(feu.PcxLigneBlanche.Bounds))
                {
                    if (!feu.Etat)
                    {
                        vehicle.CollisionFeu = true;
                    }
                    else
                    {
                        vehicle.CollisionFeu = false;
                    }
                }
            }
        }
        private void tmrFeu_Tick(object sender, EventArgs e)
        {
            compteurFeu++;
            if (compteurFeu >= 6)
            {
                compteurFeu = 0;
                foreach (var feu in feuList)
                {
                    feu.Etat = !feu.Etat;
                }
            }
        }
    }
}
