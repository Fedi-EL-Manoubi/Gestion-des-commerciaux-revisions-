using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_commerciaux_révisions_
{
    // Classe NoteFrais
    class NoteFrais
    {
        public int Numero { get; }
        public DateTime DateDepense { get; }
        public double MontantRembourse { get; }
        public char TypeFrais { get; }
        public bool Remboursee { get; }
        public Commercial LeCommercial { get; }

        public NoteFrais(int numero, DateTime dateDepense, double montantRembourse, char typeFrais, bool remboursee, Commercial commercial)
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
            // Implémentez la méthode ToString pour afficher les informations de la note de frais
            // ainsi que le nom et prénom du commercial.
        }
    }
}
