using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace GestionCirculation
{
    class Program : VehiculesEnCirculation
    {
        static void Main(string[] args)
        {
            VehiculesEnCirculation V1 = new VehiculesEnCirculation();
            VehiculesEnCirculation V2 = new VehiculesEnCirculation();
            VehiculesEnCirculation V3 = new VehiculesEnCirculation();
            VehiculesEnCirculation V4 = new VehiculesEnCirculation();
            VehiculesEnCirculation V5 = new VehiculesEnCirculation();

            V1.CeintureVerifier = true;
            

            V1.MarqueAuto(); V1.CouleurCarrosserieAuto(); V1.ordinateurDeBord(); Thread.Sleep(3000); Console.Clear();

            V2.MarqueAuto(); V2.CouleurCarrosserieAuto(); V2.ordinateurDeBord(); Thread.Sleep(3000); Console.Clear();

            V3.MarqueAuto(); V3.CouleurCarrosserieAuto(); V3.ordinateurDeBord(); Thread.Sleep(3000); Console.Clear();

            V4.MarqueAuto(); V4.CouleurCarrosserieAuto(); V4.ordinateurDeBord(); Thread.Sleep(3000); Console.Clear();

            V5.MarqueAuto(); V5.CouleurCarrosserieAuto(); V5.ordinateurDeBord(); Thread.Sleep(3000); Console.Clear();


        }
    }
}
