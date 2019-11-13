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
    /// Lógica de interacción para Agregar.xaml
    /// </summary>
    public partial class Agregar : UserControl
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void Cb_pelicula_Checked(object sender, RoutedEventArgs e)
        {
            grid_2.Children.Clear();
            grid_2.Children.Add(new Peliculas());
        }

        private void Cb_serie_Checked(object sender, RoutedEventArgs e)
        {
            grid_2.Children.Clear();
            grid_2.Children.Add(new Series());
        }
    }
}
