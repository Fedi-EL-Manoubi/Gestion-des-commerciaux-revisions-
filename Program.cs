using Gestion_des_commerciaux_révisions_;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Commercial c1 = new Commercial(1, "Noix", "patex", 4, 150);

            Commercial c2 = new Commercial(2, "alex", "Perrera", 2, 200);
            Commercial c3 = new Commercial(3, "Khamzat ", "Chimaev", 3, 180);
            Commercial c4 = new Commercial(4, "Brown", "Emma", 1, 170);

            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);

            Note n1 = new Note(1, new DateTime(2023, 1, 15), 50, 'r', false, c2);
            Note n2 = new Note(2, new DateTime(2023, 2, 20), 120, 'n', true, c2);
            Note n3 = new Note(3, new DateTime(2023, 3, 10), 80, 't', false, c3);
            Note n4 = new Note(4, new DateTime(2023, 4, 5), 70, 'r', true, c3);
            Note n5 = new Note(5, new DateTime(2023, 5, 25), 90, 'n', false, c4);
            Note n6 = new Note(6, new DateTime(2023, 6, 30), 60, 't', true, c4);

            c2.AjouterNoteFrais(n1);
            c2.AjouterNoteFrais(n2);
            c3.AjouterNoteFrais(n3);
            c3.AjouterNoteFrais(n4);
            c4.AjouterNoteFrais(n5);
            c4.AjouterNoteFrais(n6);

            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);

            ServiceCommercial s1 = new ServiceCommercial("National");
            ServiceCommercial s2 = new ServiceCommercial("International");

            s1.AjouterCommercial(c2);
            s1.AjouterCommercial(c3);
            s2.AjouterCommercial(c4);

            Console.WriteLine("Notes non remboursées pour le service National:");
            foreach (var note in s1.NotesFraisNonRemboursees())
            {
                Console.WriteLine(note);
            }

            Console.WriteLine("Notes non remboursées pour le service International:");
            foreach (var note in s2.NotesFraisNonRemboursees())
            {
                Console.WriteLine(note);
            }

            int annee = 2023;
            Console.WriteLine($"Le cumul pour le commercial {c2.Nom} {c2.Prenom} pour l'année {annee} est de {c2.CumulNotesRembourseesParAnnee(annee)} €");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Une exception a été levée : {ex.Message}");
        }
    }
}