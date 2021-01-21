using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projet_Info_Année_3
{
    /// <summary>
    /// Logique d'interaction pour AffichageMembres.xaml
    /// </summary>
    public partial class AffichageMembres : Window
    {
        ObservableCollection<Membre> items1;
        List<Membre> items;

        public AffichageMembres()
        {
            items = new List<Membre>();
            items.Add(new Membre() { Nom = "Toto", Prenom = "pol", Age = 42, Adresse = "12 RUE DE PARIS" });
            items.Add(new Membre() { Nom = "To", Prenom = "poiil", Age = 42, Adresse = "1 RUE DE PIS" });
            items.Add(new Membre() { Nom = "Topo", Prenom = "puuuol", Age = 42, Adresse = "2 RUE DE PRIS" });
            items1 = new ObservableCollection<Membre>{new Membre() { Nom = "Toto", Prenom = "pol", Age = 42, Adresse = "12 RUE DE PARIS" },
                new Membre() { Nom = "To", Prenom = "poiil", Age = 42, Adresse = "1 RUE DE PIS" },
                new Membre() { Nom = "Topo", Prenom = "puuuol", Age = 42, Adresse = "2 RUE DE PRIS" } };
            this.DataContext = this;

            InitializeComponent();

            lvUsers.ItemsSource = items1;

        }
        private void Bouton_Selectionner(object sender, RoutedEventArgs e)
        {
            foreach (object o in lvUsers.SelectedItems)
            {
                //  MessageBox.Show(o.ToString());
                FenetreAjout w = new FenetreAjout((Membre)o);
                w.Show();
                w.Box1.Text = ((Membre)o).Nom;
                w.Box2.Text = ((Membre)o).Prenom;
                w.Box2.Text = ((Membre)o).Adresse;
                w.Box3.Text = ((Membre)o).Age.ToString();
            }

        }

        private void Button_Fin(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Ajouter(object sender, RoutedEventArgs e)
        {
            FenetreModification w2 = new FenetreModification(items1);
            w2.Show();
        }

        private void RetourMenu(object sender, RoutedEventArgs e)
        {
            MainWindow NvFenetre = new MainWindow();
            NvFenetre.Show();
            this.Close();          
        }
    }
}
