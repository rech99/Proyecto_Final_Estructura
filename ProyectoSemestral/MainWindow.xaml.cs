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
using System.Collections.ObjectModel;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoSemestral
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        ObservableCollection<Conjunto> conjunto = new ObservableCollection<Conjunto>();

        public MainWindow()
        {
            InitializeComponent();

            Pelicula peli1 = new Pelicula("Martin Campbell", "James Bond se embarca en su primera mision", "Accion", "007 Casino Royale", 2007, 5);
            Pelicula peli2 = new Pelicula("Guillermo Del Toro", "Drama fantastico sobre la Guerra Civil Española", "Drama", "El Laberinto del Fauno", 2006, 5);
            Pelicula peli3 = new Pelicula("Alejandro G. Iñarritu", "Comedia Negra de superheroes", "Drama", "Birdman", 2014, 4);

            Serie ser1 = new Serie("Supernatural", "Terror", "Hermanos se enfrentan a lo desconcoido", "Warner", "Jeffrey Dean Morgan", 2006, 5, 3);
            Serie ser2 = new Serie("Terminator", "Comedia", "Avebturas de una famila disfuncianal", "Fox", "Matt Groening", 1999, 30, 2);

            conjunto.Add(peli1);
            conjunto.Add(peli2);
            conjunto.Add(peli3);
            conjunto.Add(ser1);
            conjunto.Add(ser2);

            lst_catalogo.ItemsSource = conjunto;





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

        private void lst_catalogo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lst_catalogo.SelectedIndex != -1)
            {
                Grid1.Children.Clear();
                Grid1.Children.Add(new Ver());

            }



        }
    }
}
