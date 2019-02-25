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
    class carTestClass
    {
        private double _vitesse;
        private double _posX;
        private double _posY;
        private string _pointDepart;
        private string _pointArrivee;
        private int _direction;
        private PictureBox _pcbCar;

        public double Vitesse { get => _vitesse; set => _vitesse = value; }
        public double PosX { get => _posX; set => _posX = value; }
        public double PosY { get => _posY; set => _posY = value; }
        public string PointDepart { get => _pointDepart; set => _pointDepart = value; }
        public string PointArrivee { get => _pointArrivee; set => _pointArrivee = value; }
        public PictureBox PcbCar { get => _pcbCar; set => _pcbCar = value; }
        public int Direction { get => _direction; set => _direction = value; }

        public carTestClass(double vitesse, double posX, double posY, string depart, string arriver, PictureBox pcbcar, int direction)
        {
            this.Vitesse = vitesse;
            this.PosX = posX;
            this.PosY = posY;
            this.PointDepart = depart;
            this.PointArrivee = arriver;
            this.PcbCar = pcbcar;
            this.Direction = direction;
        }
        public void Avancer()
        {
            Vitesse = 30;
        }

        public void Stopper()
        {
            Vitesse = 0;
        }
    }
}
