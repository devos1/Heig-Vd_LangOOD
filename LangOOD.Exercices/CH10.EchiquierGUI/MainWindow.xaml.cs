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
            createGrid();

            Echiquier echiquier = new Echiquier();

            // Traitement ligne 1
            List<Pieces> listeLigne1 = new List<Pieces>();
            listeLigne1 = echiquier.getPiecesLigne(0);
            customRow(0, listeLigne1);

            // Traitement ligne 2
            List<Pieces> listeLigne2 = new List<Pieces>();
            listeLigne2 = echiquier.getPiecesLigne(1);
            customRow(1, listeLigne2);

            // Traitement ligne 3 - 4 - 5 - 6
            List<Pieces> listeLigne3 = new List<Pieces>();
            listeLigne3 = echiquier.getPiecesLigne(2);
            customRow(2, listeLigne3);
            customRow(3, listeLigne3);
            customRow(4, listeLigne3);
            customRow(5, listeLigne3);

            // Traitement ligne 7
            List<Pieces> listeLigne7 = new List<Pieces>();
            listeLigne7 = echiquier.getPiecesLigne(6);
            customRow(6, listeLigne7);

            // Traitement ligne 8
            List<Pieces> listeLigne8 = new List<Pieces>();
            listeLigne8 = echiquier.getPiecesLigne(7);
            customRow(7, listeLigne8);

        }

        private void customRow(int row, List<Pieces> listeLigne)
        {
            int col = 0;
            foreach (var item in listeLigne)
            {           
                Label lbl = new Label();
                lbl.Content = item.ToString();
                lbl.SetValue(Grid.RowProperty, row);
                lbl.SetValue(Grid.ColumnProperty, col);
                lbl.HorizontalAlignment = HorizontalAlignment.Center;
                lbl.VerticalAlignment = VerticalAlignment.Center;
                lbl.FontSize = 16;
                grilleEchecs.Children.Add(lbl);

                switch (row)
                {
                    case 0:
                    case 1:
                        lbl.FontWeight = FontWeights.Bold;
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        lbl.FontWeight = FontWeights.Light;
                        lbl.FontStyle = FontStyles.Italic;
                        lbl.Foreground = new SolidColorBrush(Colors.Gray);
                        break;
                    case 6:
                    case 7:
                        lbl.FontWeight = FontWeights.Bold;
                        lbl.Foreground = new SolidColorBrush(Colors.White);
                        break;
                    default:
                        break;
                }

                col++;
            }
        }

        private void createGrid()
        {
            grilleEchecs.ColumnDefinitions.Add(new ColumnDefinition());
            grilleEchecs.ColumnDefinitions.Add(new ColumnDefinition());
            grilleEchecs.ColumnDefinitions.Add(new ColumnDefinition());
            grilleEchecs.ColumnDefinitions.Add(new ColumnDefinition());
            grilleEchecs.ColumnDefinitions.Add(new ColumnDefinition());
            grilleEchecs.ColumnDefinitions.Add(new ColumnDefinition());
            grilleEchecs.ColumnDefinitions.Add(new ColumnDefinition());
            grilleEchecs.ColumnDefinitions.Add(new ColumnDefinition());

            grilleEchecs.RowDefinitions.Add(new RowDefinition());
            grilleEchecs.RowDefinitions.Add(new RowDefinition());
            grilleEchecs.RowDefinitions.Add(new RowDefinition());
            grilleEchecs.RowDefinitions.Add(new RowDefinition());
            grilleEchecs.RowDefinitions.Add(new RowDefinition());
            grilleEchecs.RowDefinitions.Add(new RowDefinition());
            grilleEchecs.RowDefinitions.Add(new RowDefinition());
            grilleEchecs.RowDefinitions.Add(new RowDefinition());

            for (int i = 0; i < 8; i+=2)
            {
                Grid a8 = new Grid();
                a8.HorizontalAlignment = HorizontalAlignment.Left;
                a8.VerticalAlignment = VerticalAlignment.Top;
                a8.Width = 50;
                a8.Height = 50;
                a8.Background = new SolidColorBrush(Color.FromRgb(255, 206, 158));
                a8.SetValue(Grid.RowProperty, i);
                a8.SetValue(Grid.ColumnProperty, 0);

                Grid a7 = new Grid();
                a7.HorizontalAlignment = HorizontalAlignment.Left;
                a7.VerticalAlignment = VerticalAlignment.Top;
                a7.Width = 50;
                a7.Height = 50;
                a7.Background = new SolidColorBrush(Color.FromRgb(209, 139, 71));
                a7.SetValue(Grid.RowProperty, i);
                a7.SetValue(Grid.ColumnProperty, 1);

                Grid a6 = new Grid();
                a6.HorizontalAlignment = HorizontalAlignment.Left;
                a6.VerticalAlignment = VerticalAlignment.Top;
                a6.Width = 50;
                a6.Height = 50;
                a6.Background = new SolidColorBrush(Color.FromRgb(255, 206, 158));
                a6.SetValue(Grid.RowProperty, i);
                a6.SetValue(Grid.ColumnProperty, 2);

                Grid a5 = new Grid();
                a5.HorizontalAlignment = HorizontalAlignment.Left;
                a5.VerticalAlignment = VerticalAlignment.Top;
                a5.Width = 50;
                a5.Height = 50;
                a5.Background = new SolidColorBrush(Color.FromRgb(209, 139, 71));
                a5.SetValue(Grid.RowProperty, i);
                a5.SetValue(Grid.ColumnProperty, 3);

                Grid a4 = new Grid();
                a4.HorizontalAlignment = HorizontalAlignment.Left;
                a4.VerticalAlignment = VerticalAlignment.Top;
                a4.Width = 50;
                a4.Height = 50;
                a4.Background = new SolidColorBrush(Color.FromRgb(255, 206, 158));
                a4.SetValue(Grid.RowProperty, i);
                a4.SetValue(Grid.ColumnProperty, 4);

                Grid a3 = new Grid();
                a3.HorizontalAlignment = HorizontalAlignment.Left;
                a3.VerticalAlignment = VerticalAlignment.Top;
                a3.Width = 50;
                a3.Height = 50;
                a3.Background = new SolidColorBrush(Color.FromRgb(209, 139, 71));
                a3.SetValue(Grid.RowProperty, i);
                a3.SetValue(Grid.ColumnProperty, 5);

                Grid a2 = new Grid();
                a2.HorizontalAlignment = HorizontalAlignment.Left;
                a2.VerticalAlignment = VerticalAlignment.Top;
                a2.Width = 50;
                a2.Height = 50;
                a2.Background = new SolidColorBrush(Color.FromRgb(255, 206, 158));
                a2.SetValue(Grid.RowProperty, i);
                a2.SetValue(Grid.ColumnProperty, 6);
            
                Grid a1 = new Grid();
                a1.HorizontalAlignment = HorizontalAlignment.Left;
                a1.VerticalAlignment = VerticalAlignment.Top;
                a1.Width = 50;
                a1.Height = 50;
                a1.Background = new SolidColorBrush(Color.FromRgb(209, 139, 71));
                a1.SetValue(Grid.RowProperty, i);
                a1.SetValue(Grid.ColumnProperty, 7);
            
                grilleEchecs.Children.Add(a8);
                grilleEchecs.Children.Add(a7);
                grilleEchecs.Children.Add(a6);
                grilleEchecs.Children.Add(a5);
                grilleEchecs.Children.Add(a4);
                grilleEchecs.Children.Add(a3);
                grilleEchecs.Children.Add(a2);
                grilleEchecs.Children.Add(a1);

            }

            for (int i = 1; i < 8; i += 2)
            {
                Grid a8 = new Grid();
                a8.HorizontalAlignment = HorizontalAlignment.Left;
                a8.VerticalAlignment = VerticalAlignment.Top;
                a8.Width = 50;
                a8.Height = 50;
                a8.Background = new SolidColorBrush(Color.FromRgb(209, 139, 71));
                a8.SetValue(Grid.RowProperty, i);
                a8.SetValue(Grid.ColumnProperty, 0);

                Grid a7 = new Grid();
                a7.HorizontalAlignment = HorizontalAlignment.Left;
                a7.VerticalAlignment = VerticalAlignment.Top;
                a7.Width = 50;
                a7.Height = 50;
                a7.Background = new SolidColorBrush(Color.FromRgb(255, 206, 158));
                a7.SetValue(Grid.RowProperty, i);
                a7.SetValue(Grid.ColumnProperty, 1);

                Grid a6 = new Grid();
                a6.HorizontalAlignment = HorizontalAlignment.Left;
                a6.VerticalAlignment = VerticalAlignment.Top;
                a6.Width = 50;
                a6.Height = 50;
                a6.Background = new SolidColorBrush(Color.FromRgb(209, 139, 71));
                a6.SetValue(Grid.RowProperty, i);
                a6.SetValue(Grid.ColumnProperty, 2);

                Grid a5 = new Grid();
                a5.HorizontalAlignment = HorizontalAlignment.Left;
                a5.VerticalAlignment = VerticalAlignment.Top;
                a5.Width = 50;
                a5.Height = 50;
                a5.Background = new SolidColorBrush(Color.FromRgb(255, 206, 158));
                a5.SetValue(Grid.RowProperty, i);
                a5.SetValue(Grid.ColumnProperty, 3);

                Grid a4 = new Grid();
                a4.HorizontalAlignment = HorizontalAlignment.Left;
                a4.VerticalAlignment = VerticalAlignment.Top;
                a4.Width = 50;
                a4.Height = 50;
                a4.Background = new SolidColorBrush(Color.FromRgb(209, 139, 71));
                a4.SetValue(Grid.RowProperty, i);
                a4.SetValue(Grid.ColumnProperty, 4);

                Grid a3 = new Grid();
                a3.HorizontalAlignment = HorizontalAlignment.Left;
                a3.VerticalAlignment = VerticalAlignment.Top;
                a3.Width = 50;
                a3.Height = 50;
                a3.Background = new SolidColorBrush(Color.FromRgb(255, 206, 158));
                a3.SetValue(Grid.RowProperty, i);
                a3.SetValue(Grid.ColumnProperty, 5);

                Grid a2 = new Grid();
                a2.HorizontalAlignment = HorizontalAlignment.Left;
                a2.VerticalAlignment = VerticalAlignment.Top;
                a2.Width = 50;
                a2.Height = 50;
                a2.Background = new SolidColorBrush(Color.FromRgb(209, 139, 71));
                a2.SetValue(Grid.RowProperty, i);
                a2.SetValue(Grid.ColumnProperty, 6);

                Grid a1 = new Grid();
                a1.HorizontalAlignment = HorizontalAlignment.Left;
                a1.VerticalAlignment = VerticalAlignment.Top;
                a1.Width = 50;
                a1.Height = 50;
                a1.Background = new SolidColorBrush(Color.FromRgb(255, 206, 158));
                a1.SetValue(Grid.RowProperty, i);
                a1.SetValue(Grid.ColumnProperty, 7);

                grilleEchecs.Children.Add(a8);
                grilleEchecs.Children.Add(a7);
                grilleEchecs.Children.Add(a6);
                grilleEchecs.Children.Add(a5);
                grilleEchecs.Children.Add(a4);
                grilleEchecs.Children.Add(a3);
                grilleEchecs.Children.Add(a2);
                grilleEchecs.Children.Add(a1);

            }

        }
    }
}
