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
    /// Logique d'interaction pour FenetreModification.xaml
    /// </summary>
    public partial class FenetreModification : Window
    {
        public ObservableCollection<Membre> u;

        public FenetreModification(ObservableCollection<Membre> u)
        {
            InitializeComponent();
            this.u = u;
        }
               
        
        private void but2_Click(object sender, RoutedEventArgs e)
        {

            Membre monuser = new Membre();
            monuser.Nom = Box11.Text;
            //monuser.Adresse = Box44.Text;
            monuser.Age = Convert.ToInt32(Box33.Text);
            monuser.Prenom = Box22.Text;
            u.Add(monuser);
            this.Close();

        }
    }
}
