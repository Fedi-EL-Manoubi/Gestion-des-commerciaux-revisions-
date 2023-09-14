using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_commerciaux_révisions_
{
    // Classe Commercial
    class Commercial
    {
        public int Identifiant { get; }
        public string Nom { get; }
        public string Prenom { get; }
        public int CategorieProfessionnelle { get; }
        public int PuissanceVoiture { get; }
        public ServiceCommercial Service { get; }
        public List<NoteFrais> NotesDeFrais { get; } = new List<NoteFrais>();

        public Commercial(int identifiant, string nom, string prenom, int categorieProfessionnelle, int puissanceVoiture, ServiceCommercial service)
        {

            if (categorieProfessionnelle < 1 || categorieProfessionnelle > 3)
            {
                throw new Exception("La catégorie professionnelle doit être 1, 2 ou 3.");
            }

            Identifiant = identifiant;
            Nom = nom;
            Prenom = prenom;
            CategorieProfessionnelle = categorieProfessionnelle;
            PuissanceVoiture = puissanceVoiture;
            Service = service;
        }

        public void AjouterNoteFrais(NoteFrais note)
        {
            NotesDeFrais.Add(note);
        }

        public override string ToString()
        {
            // Implémentez la méthode ToString pour afficher les informations du commercial
            // ainsi que ses notes de frais.
            // Vous pouvez utiliser StringBuilder pour construire la chaîne de caractères.
        }

        public double CumulNotesRembourseesParAnnee(int annee)
        {
            
        }
    }
}
