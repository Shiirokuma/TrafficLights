using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightsGroupe4
{
    interface IUsager
    {
        double Vitesse { get; set; }
        void Stopper();
        void Accelerer();

    }
}
