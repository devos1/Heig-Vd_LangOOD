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

namespace CH07.Singleton
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

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            Objet o = Objet.CreateInstance;
            o.texteInstance = "I'm an instance";
            lblLeft.Content = Objet.GetInstancesCount();
            lblRight.Content = o.texteInstance;
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            Objet o1 = Objet.CreateInstance;
            lblLeft.Content = Objet.GetInstancesCount();
            o1.texteInstance = "Or Not";
            lblRight.Content = o1.texteInstance;
        }
    }
}
