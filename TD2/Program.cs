using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employer nouvelEmploye = employer.AjoutEmploye();

            Console.WriteLine("\nINFORMATION DE L'EMPLOYER:");
            Console.WriteLine("PRENOM: "+nouvelEmploye.Prenom);
            Console.WriteLine("NOM: "+nouvelEmploye.Nom);
            Console.WriteLine("ÂGE: "+nouvelEmploye.Age);
            Console.WriteLine("NUM EMPLOYER: "+nouvelEmploye.NumeroEmploye);
            Console.WriteLine("DEPARTEMENT: "+nouvelEmploye.DepartementEmploye);

            Console.Write("\nENTREZ LE NOMBRE D'EMPLOYER DANS LE TABLEAU: ");
            int tailleTableau;
            while (!int.TryParse(Console.ReadLine(), out tailleTableau) || tailleTableau < 1)
            {
                Console.WriteLine("VALEUR INVALIDE.");
                Console.Write("ENTREZ LE NOMBRE D'EMPLOYER A AJOUTER DANS LE TABLEAU: ");
            }

            employer[] tableauEmployes = employer.RemplirTableau(tailleTableau);

            // Affiche les informations de tous les employés dans le tableau
            Console.WriteLine("\nINFORMATION EMPLOYER DU TABLEAU");
            foreach (employer employe in tableauEmployes)
            {
                Console.WriteLine("PRENOM: "+employe.Prenom);
                Console.WriteLine("NOM: "+employe.Nom);
                Console.WriteLine("ÂGE: "+employe.Age);
                Console.WriteLine("NUM EMPLOYER: "+employe.NumeroEmploye);
                Console.WriteLine("DPARTEMENTE: "+employe.DepartementEmploye);
                Console.ReadKey();
            }
        }
       
    }
}
