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
using System.Threading;
using System.Threading.Tasks;

namespace TrafficLightsGroupe4
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool lightState = false; // traffic light is red
            Voiture voiture = new Voiture(5, 10, 10);
            Random rnd = new Random();
            Console.Write("Traffic light state: ");
            lightState = Convert.ToBoolean(Console.ReadLine());
            int posX = 0;
            Vehicule vehicule = new Voiture(12, 0, 10);
            Feu feu = new Feu(60, 10);
            //ConsoleKeyInfo info = Console.ReadKey();

            List<Vehicule> vehicules = new List<Vehicule>() {
                new Voiture(5, 10, 10),
                new Bus(3, 10, 20)
                };

            Console.Write("Vehicule pos x: ");
            /*if (info.Key == ConsoleKey.Escape)
            {
                Console.SetCursorPosition(0, 5);

                Console.WriteLine("Stop");
            }*/

            if (lightState == true)
            {
                //posX++;
                voiture.Accelerer();
                Console.SetCursorPosition(15, 1);
                Console.Write(voiture.PosX);
                Thread.Sleep(1000);

                /*Console.SetCursorPosition(posX - 1, 1);
                Console.Write(" ");
                Console.SetCursorPosition(posX, 1);
                Console.WriteLine(".===.");
                Console.SetCursorPosition(posX - 1, 2);
                Console.Write(" ");
                Console.SetCursorPosition(posX, 2);
                Console.Write("o---o");
                Thread.Sleep(1000);*/
            }
            /* foreach (Vehicule v in vehicules)
             {
                 v.Accelerer();
                 Console.Write("Vehicule: ");
                 Console.Write("\r{0}   ", v.PosX);
                 Thread.Sleep(1000);

             }*/

            Console.ReadKey();


            for (int i = 0; i < 100; ++i)
            {
                Console.Write("\r{0}%   ", i);
                Thread.Sleep(1000);
            }



        }
    }
    }
