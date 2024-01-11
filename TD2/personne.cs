using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2
{
    internal class personne
    {
        private string prenom;
        private string nom;
        private int age;
        public personne()
        {
          
            prenom = "";
            nom = "";
            age = 0;
        }
        public personne(string prenom, string nom, int age)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.age = age;
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }


    }
}
