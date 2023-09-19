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
        private int v1;
        private readonly string v2;
        private string v3;
        private int v4;
        private int v5;

        public int Identifiant { get; }
        public string Nom { get; }
        public string Prenom { get; }
        public int CategorieProfessionnelle { get; }
        public int PuissanceVoiture { get; }
        public ServiceCommercial Service { get; }
        public List<Note> NotesDeFrais { get; } = new List<Note>();

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

        public Commercial(int v1, string v2, string v3, int v4, int v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        public void AjouterNoteFrais(Note note)
        {
            NotesDeFrais.Add(note);
        }

  
 
        public override string ToString()
            {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Identifiant : {Identifiant}");
            sb.AppendLine($"Nom : {Nom}");
            sb.AppendLine($"Prénom : {Prenom}");
            sb.AppendLine($"Catégorie Professionnelle : {CategorieProfessionnelle}");
            sb.AppendLine($"Puissance de Voiture : {PuissanceVoiture}");


            sb.AppendLine("Notes de frais :");
                foreach (var note in NotesDeFrais)
                {
                    sb.AppendLine(note.ToString());
                }

            return sb.ToString();
        }

        internal object CumulNotesRembourseesParAnnee(int annee)
        {
            throw new NotImplementedException();
        }
    }
}
