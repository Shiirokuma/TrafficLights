using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightsGroupe4
{
    public class Feux
    {
        private string _type;
        private bool _etat;

        public string Type { get => _type; set => _type = value; }
        public bool Etat { get => _etat; set => _etat = value; }
        public Feux(string type, bool etat)
        {
            Type = type;
            Etat = etat;
        }
        public void ChangemantDEtat()
        {
            Etat = !Etat;
        }
    }
}
