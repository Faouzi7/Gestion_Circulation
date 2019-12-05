using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace GestionCirculation
{
    public class VehiculesEnCirculation : ConstructeurVehicule
    {
        bool fileDeDroite;
        bool fileDuMilieu;
        bool fileDeGauche;
        private bool _ceintureAttacher = true;
        int AgeConducteur;



        public bool CeintureVerifier
        {
            get
            {
                return _ceintureAttacher;
            }

            set
            {
                _ceintureAttacher = value;
            }

        }


        public void ordinateurDeBord()
        {

            Random rnd = new Random();
            int vitesse = rnd.Next(0, 130);
            Console.WriteLine($" véhicule roulant à " + vitesse + " km/h");

            if (vitesse>0 && vitesse <= 70)
            {
                Console.WriteLine("Bonne conduite");
            }

            else if (vitesse >= 70)
            {
                Console.WriteLine("Vitesse au dela la la limite autorisée");
            }

            else
            {
                Console.WriteLine("Le vehicule est a l'arret");
            }
        }
    }
}
