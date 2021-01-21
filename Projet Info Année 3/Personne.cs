using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Info_Année_3
{
    public class Personne
    {
        #region Attributs
        string nom;
        string prenom;
        int age;
        string adresse;
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        #region Constructeur
        public Personne()
        { }
        public Personne(string nom,string prenom, int age, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.adresse = adresse;
        }
#endregion

        #region Propriétés
        public string Nom
        {
            get { return nom; }
            set { nom = value; OnPropertyChanged("Nom"); }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; OnPropertyChanged("Nom"); }
        }

        public int Age
        {
            get { return age; }
            set { age = value; OnPropertyChanged("Age"); }
        }


        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; OnPropertyChanged("Mail"); }
        }
        #endregion

        #region Méthodes
        public override string ToString()
        {
            return this.Nom + ", " + this.Age + " ans";
        }
        //   public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        // Creer  OnPropertyChanged pour déclencher l'évènement
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
    }
}
