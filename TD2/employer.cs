using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2
{
    internal class employer : personne
    {
        private int numeroEmploye;
        private string departementEmploye;
        public employer (string prenom, string nom, int age, int numeroEmploye, string departementEmploye)
      : base(prenom, nom, age)
        {
            this.numeroEmploye = numeroEmploye;
            this.departementEmploye = departementEmploye;
        }
        public int NumeroEmploye
        {
            get { return numeroEmploye; }
            set { numeroEmploye = value; }
        }
        public string DepartementEmploye
        {
            get { return departementEmploye; }
            set { departementEmploye = value; }
        }
        public static employer AjoutEmploye()
        {
            Console.WriteLine("ENTRER LES INFOS DE L'EMPLOYER:");

            Console.Write("PRENOM: ");
            string prenom = Console.ReadLine();

            Console.Write("NOM: ");
            string nom = Console.ReadLine();

            Console.Write("ÂGE: ");
            int age = int.Parse(Console.ReadLine());
            

            Console.Write("NUM ENPLOYER: ");
            int numeroEmploye =int.Parse(Console.ReadLine());
           
            Console.Write("DEPARTEMENT: ");
            string departement = Console.ReadLine();

            return new employer(prenom, nom, age, numeroEmploye, departement);
        }
        public static employer[] RemplirTableau(int taille)
        {
            employer[] tableauEmployes = new employer[taille];

            for (int i = 0; i < taille; i++)
            {
                Console.WriteLine($"\n ENTREZ LES INFOS POUR L'EMPLOYER {i + 1}:");
                tableauEmployes[i] = AjoutEmploye();
            }

            return tableauEmployes;
        }
    }
}
