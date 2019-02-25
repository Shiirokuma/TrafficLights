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
    public class Feu
    {
        private string _type;
        private bool _etat;
        private PictureBox _pcxLigneBlanche;
        private PictureBox _pcxfeu;

        public string Type { get => _type; set => _type = value; }
        public bool Etat { get => _etat; set => _etat = value; }
        public PictureBox PcxLigneBlanche { get => _pcxLigneBlanche; set => _pcxLigneBlanche = value; }
        internal PictureBox PcxFeu { get => _pcxfeu; set => _pcxfeu = value; }

        public Feu(string type, bool etat, PictureBox pcxLigneBlanche, PictureBox pcxFeu)
        {
            Type = type;
            Etat = etat;
            PcxLigneBlanche = pcxLigneBlanche;
            PcxFeu = pcxFeu;
        }
        public void ChangemantDEtat()
        {
            Etat = !Etat;
        }
    }
}
