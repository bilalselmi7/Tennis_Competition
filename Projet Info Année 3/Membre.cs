using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Info_Année_3
{
    public class Membre : Personne
    {
        public Membre(string nom, string prenom, int age, string adresse) : base(nom,prenom,age,adresse)
        {
            
        }
        public Membre()
        { }
    }
}
