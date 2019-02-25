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
    class FeuTestClass
    {
        private string _type;
        private bool _etat;
        private PictureBox whiteStrip;
        private PictureBox feu;

        public string Type { get => _type; set => _type = value; }
        public bool Etat { get => _etat; set => _etat = value; }
        public PictureBox WhiteStrip { get => whiteStrip; set => whiteStrip = value; }
        public PictureBox Feu { get => feu; set => feu = value; }

        public FeuTestClass(string type, bool etat, PictureBox whiteStrip, PictureBox feu)
        {
            Type = type;
            Etat = etat;
            Feu = feu;
            WhiteStrip = whiteStrip;
        }
        public void ChangemantDEtat()
        {
            Etat = !Etat;
        }
    }
}
