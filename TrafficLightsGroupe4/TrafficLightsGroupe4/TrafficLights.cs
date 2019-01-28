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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLightsGroupe4
{
    public partial class TrafficLights : Form
    {
        /*
         * Liste des images (png)
         * 0 Bus                   10 FeuVertBottom             20 Null
         * 1 CederPassageDown      11 FeuVertLeft               21 velo
         * 2 CederPassageUp        12 FeuVertRight              22 voitureBOTTOM
         * 3 CedezLePassage        13 FeuVertTop                23 voitureLEFT
         * 4 FeuRouge              14 feuxPietons               24 voitureRIGHT
         * 5 FeuRougeBottom        15 FeuxPietonsRougeLeft      25 voitureTOP
         * 6 FeuRougeLeft          16 FeuxPietonsRougeRight
         * 7 FeuRougeRight         17 FeuxPietonsVertLeft
         * 8 FeuRougeTop           18 FeuxPietonsVertRight
         * 9 FeuVert               19 motoTOP
         */
        public TrafficLights()
        {
            InitializeComponent();
        }
    }
}
