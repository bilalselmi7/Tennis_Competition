using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour FenetreAjout.xaml
    /// </summary>
    public partial class FenetreAjout : Window
    {
        Membre monuser;
        public FenetreAjout(Membre monuser)
        {
            InitializeComponent();
            this.monuser = monuser;
        }




        private void but2_Click(object sender, RoutedEventArgs e)
        {
            monuser.Nom = Box1.Text;
            monuser.Age = Convert.ToInt16(Box3.Text);
            monuser.Prenom = Box2.Text;
            this.Close();
        }
    }
}
