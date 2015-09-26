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

namespace CH10.EchiquierGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Création Labels pour les pièces dans la grille
            Label lblA1 = new Label();
            Label lblA2 = new Label();


            Echiquier echiquier = new Echiquier();
            Pieces p = echiquier.getPiecePosition(0, 0);

            List<Pieces> listeP = new List<Pieces>();
            listeP = echiquier.getPiecesLigne(0);

            // Affichage ligne 1


            //essageBox.Show(p.ToString());

            lblA1.Content = p.ToString();
            lblA2.Content = "test";
            a1.Children.Add(lblA1);
            a2.Children.Add(lblA2);

        }

        private void createGrid()
        {
            // Create the Grid
            Grid DynamicGrid = new Grid();
            DynamicGrid.Width = 400;
            DynamicGrid.HorizontalAlignment = HorizontalAlignment.Left;
            DynamicGrid.VerticalAlignment = VerticalAlignment.Top;
            DynamicGrid.ShowGridLines = true;
            DynamicGrid.Background = new SolidColorBrush(Colors.LightSteelBlue);
        }
    }
}
