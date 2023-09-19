using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_commerciaux_révisions_
{
    class ServiceCommercial
    {
        public string NomService { get; }
        public List<Commercial> Commerciaux { get; } = new List<Commercial>();

        public ServiceCommercial(string nomService)
        {
            NomService = nomService;
        }

        public void AjouterCommercial(Commercial commercial)
        {
            Commerciaux.Add(commercial);
        }
        public List<Note> NotesFraisNonRemboursees()
        {
            List<Note> notesNonRemboursees = new List<Note>();

            foreach (var commercial in Commerciaux)
            {
                // Parcourez les notes de frais de chaque commercial
                foreach (var note in commercial.NotesDeFrais)
                {
                    if (!note.Remboursee)
                    {
                        notesNonRemboursees.Add(note);
                    }
                }
            }

            return notesNonRemboursees;
        }

    }
}
