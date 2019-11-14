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

namespace ProyectoSemestral
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Nuevo_Click(object sender, RoutedEventArgs e)
        {
            Grid1.Children.Clear();
            Grid1.Children.Add(new Agregar());
            Nuevo.Visibility = Visibility.Hidden;
            AZ.Visibility = Visibility.Hidden;
            Za.Visibility = Visibility.Hidden;
            Año_mayor.Visibility = Visibility.Hidden;
            Año_menor.Visibility = Visibility.Hidden;
            
        }

        
    }
}
