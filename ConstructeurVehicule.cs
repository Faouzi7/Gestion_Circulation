using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace GestionCirculation
{
    public class ConstructeurVehicule
    {
        private string prix;
        private string couleurCarrosserie;
        private string type;
        private string autonomieCarburant;
        private bool clignotantGauche;
        private bool clignotantDroit;

        public void MarqueAuto()
        {
            Random marqueVoitureAlea = new Random();
            List<string> MarqueVehicule = new List<string> {
                "ALFA ROMEO",
                "ASTON MARTIN",
                "TESLA",
                "VOLVO",
                "SAAB",
                "SUZUKI",
                "SMART",
                "RENAULT",
                "PORSCHE",
                "VOLKSWAGEN"
            };
            int index = marqueVoitureAlea.Next(MarqueVehicule.Count);
            MarqueVehicule.Add((MarqueVehicule[index]));
            Console.Write(MarqueVehicule[index]);
        }

        public void ImatriculationAuto() //En cours, je cherche un moyen simple pour generer automatiquement une imatriculation
        {
            Random rnd = new Random();
            List<string> imatriculation = new List<string> {
                "a",
                "b",
                "c",
                "d",
                "e",
                "f",
                "g",
                "h",
                "i",
                "j",
                "k",
                "L",
                "M"
            };

        }

        public void CouleurCarrosserieAuto()
        {
            Random couleurCarrosserieAlea = new Random();
            List<string> couleurCarrosserie = new List<string> {
                "rouge",
                "bleu",
                "blanche",
                "grise",
                "noir"
            };
            int index = couleurCarrosserieAlea.Next(couleurCarrosserie.Count);
            couleurCarrosserie.Add((couleurCarrosserie[index]));
            Console.Write(" carrosserie de couleur "+couleurCarrosserie[index]);
        }
    }
}