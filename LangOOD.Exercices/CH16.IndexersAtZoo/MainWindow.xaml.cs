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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CH16.IndexersAtZoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ZooYverdon zoo;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            zoo = new ZooYverdon();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAnimal.Text) && !String.IsNullOrEmpty(txtNourriture.Text))
            {
                zoo.addAnimalAuZoo(new Animal(txtAnimal.Text), new Nourriture(txtNourriture.Text));
            }

            txtAnimal.Text = "";
            txtNourriture.Text = "";
        }

        private void btnAnimal_Click(object sender, RoutedEventArgs e)
        {
            txtNourriture.Text = "";
            if (!string.IsNullOrEmpty(txtAnimal.Text))
            {               
                Animal animal = new Animal(txtAnimal.Text);     // Création d'un animal avec le nom voulu pour la recherche
                Nourriture nourriture = this.zoo[animal];       // Recherche de la nourriture correspondant à l'animal
                txtNourriture.Text = nourriture == null ? "Pas trouvé" : nourriture.getNom();
            }
        }

        private void btnNourriture_Click(object sender, RoutedEventArgs e)
        {
            txtAnimal.Text = "";
            if (!string.IsNullOrEmpty(txtNourriture.Text))
            {
                Nourriture nourriture = new Nourriture(txtNourriture.Text);     // Création d'une nourriture avec le nom voulu pour la recherche
                Animal animal = this.zoo[nourriture];                           // Recherche de l'animal correspondant à la nourriture
                txtAnimal.Text = animal == null ? "Pas trouvé" : animal.getNom();
            }
        }
    }
}
