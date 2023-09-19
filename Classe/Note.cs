using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_commerciaux_révisions_
{
    // Classe NoteFrais
    class Note
    {
        public int Numero { get; }
        public DateTime DateDepense { get; }
        public double MontantRembourse { get; }
        public char TypeFrais { get; }
        public bool Remboursee { get; }
        public Commercial LeCommercial { get; }

        public Note(int numero, DateTime dateDepense, double montantRembourse, char typeFrais, bool remboursee, Commercial commercial)
        {
            Numero = numero;
            DateDepense = dateDepense;
            MontantRembourse = montantRembourse;
            TypeFrais = typeFrais;
            Remboursee = remboursee;
            LeCommercial = commercial;
        }

        public override string ToString()
        {
            string typeFraisText = "";
            switch (TypeFrais)
            {
                case 'r':
                    typeFraisText = "Repas";
                    break;
                case 'n':
                    typeFraisText = "Nuitée";
                    break;
                case 't':
                    typeFraisText = "Transport";
                    break;
                default:
                    typeFraisText = "Type de frais inconnu";
                    break;
            }

           return $"Numéro de la note : {Numero}, Date de dépense : {DateDepense}, Montant à rembourser : {MontantRembourse}, Type de frais : {typeFraisText}, Remboursée : {(Remboursee ? "Oui" : "Non")}, Commercial : {LeCommercial.Nom} {LeCommercial.Prenom}";

        }
    }
}
