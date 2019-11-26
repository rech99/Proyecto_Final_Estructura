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

            Serie ser1 = new Serie("Supernatural", "Terror", "Hermanos se enfrentan a lo desconcoido", "Warner", "Jeffrey Dean Morgan", 2003, 5, 3);
            Serie ser2 = new Serie("Los Simpsons", "Comedia", "Aventuras de una famila disfuncianal", "Fox", "Matt Groening", 1999, 30, 2);

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
            btn_cancelar.Visibility = Visibility.Visible;
            btn_guardar.Visibility = Visibility.Visible;

        }

        private void lst_catalogo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lst_catalogo.SelectedIndex != -1)
            {
                Grid1.Children.Clear();
                Grid1.Children.Add(new Ver());
                edicion.Visibility = Visibility.Visible;
                Nuevo.Visibility = Visibility.Hidden;
                AZ.Visibility = Visibility.Hidden;
                Za.Visibility = Visibility.Hidden;
                Año_mayor.Visibility = Visibility.Hidden;
                Año_menor.Visibility = Visibility.Hidden;
                btn_cancelar.Visibility = Visibility.Visible;
                btn_guardar.Visibility = Visibility.Hidden;
                btn_actualizar.Visibility = Visibility.Hidden;

                ((Ver)(Grid1.Children[0])).tb_cat.Text = conjunto[lst_catalogo.SelectedIndex].Categoria;
                ((Ver)(Grid1.Children[0])).cb_nombre.Text = conjunto[lst_catalogo.SelectedIndex].Tit;
                ((Ver)(Grid1.Children[0])).cb_genero.Text = conjunto[lst_catalogo.SelectedIndex].Gen;
                ((Ver)(Grid1.Children[0])).cb_sinopsis.Text = conjunto[lst_catalogo.SelectedIndex].Sin;
                ((Ver)(Grid1.Children[0])).cb_productor.Text = conjunto[lst_catalogo.SelectedIndex].Prod;
                ((Ver)(Grid1.Children[0])).cb_director.Text = conjunto[lst_catalogo.SelectedIndex].Dir;
                ((Ver)(Grid1.Children[0])).cb_temporadas.Text = conjunto[lst_catalogo.SelectedIndex].Temp.ToString();
                ((Ver)(Grid1.Children[0])).cb_año.Text = conjunto[lst_catalogo.SelectedIndex].Año.ToString();
                ((Ver)(Grid1.Children[0])).tb_img.Text = conjunto[lst_catalogo.SelectedIndex].Rat.ToString();

                una.Visibility = Visibility.Hidden;
                dos.Visibility = Visibility.Hidden;
                tres.Visibility = Visibility.Hidden;
                cuatro.Visibility = Visibility.Hidden;
                cinco.Visibility = Visibility.Hidden;

                if (((Ver)(Grid1.Children[0])).tb_cat.Text == "Pelicula")
                {
                    ((Ver)(Grid1.Children[0])).temp_ver.Visibility = Visibility.Hidden;
                    ((Ver)(Grid1.Children[0])).cb_temporadas.Visibility = Visibility.Hidden;
                    ((Ver)(Grid1.Children[0])).prod_ver.Visibility = Visibility.Hidden;
                    ((Ver)(Grid1.Children[0])).cb_productor.Visibility = Visibility.Hidden;

                }


                if (((Ver)(Grid1.Children[0])).tb_img.Text == "1")
                {
                    una.Visibility = Visibility.Visible;
                }

                if (((Ver)(Grid1.Children[0])).tb_img.Text == "2")
                {
                    dos.Visibility = Visibility.Visible;
                }

                if (((Ver)(Grid1.Children[0])).tb_img.Text == "3")
                {
                    tres.Visibility = Visibility.Visible;
                }

                if (((Ver)(Grid1.Children[0])).tb_img.Text == "4")
                {
                    cuatro.Visibility = Visibility.Visible;
                }

                if (((Ver)(Grid1.Children[0])).tb_img.Text == "5")
                {
                    cinco.Visibility = Visibility.Visible;
                }


            }

            lst_catalogo.Items.Refresh();

        }

        private void Edicion_Click(object sender, RoutedEventArgs e)
        {

            if (lst_catalogo.SelectedIndex != -1)
            {
            

                Grid1.Children.Clear();

                

                edicion.Visibility = Visibility.Hidden;
                Nuevo.Visibility = Visibility.Hidden;
                AZ.Visibility = Visibility.Hidden;
                Za.Visibility = Visibility.Hidden;
                Año_mayor.Visibility = Visibility.Hidden;
                Año_menor.Visibility = Visibility.Hidden;
                btn_cancelar.Visibility = Visibility.Visible;
                btn_guardar.Visibility = Visibility.Hidden;
                btn_delete.Visibility = Visibility.Visible;
                btn_actualizar.Visibility = Visibility.Visible;
                una.Visibility = Visibility.Hidden;
                dos.Visibility = Visibility.Hidden;
                tres.Visibility = Visibility.Hidden;
                cuatro.Visibility = Visibility.Hidden;
                cinco.Visibility = Visibility.Hidden;

                Grid1.Children.Add(new Editar());

                ((Editar)(Grid1.Children[0])).categ.Text = conjunto[lst_catalogo.SelectedIndex].Categoria;
                ((Editar)(Grid1.Children[0])).tb_nombre_e.Text = conjunto[lst_catalogo.SelectedIndex].Tit;
                ((Editar)(Grid1.Children[0])).cb_genero_e.Text = conjunto[lst_catalogo.SelectedIndex].Gen;
                ((Editar)(Grid1.Children[0])).tb_sinopsis_e.Text = conjunto[lst_catalogo.SelectedIndex].Sin;
                ((Editar)(Grid1.Children[0])).tb_productor_e.Text = conjunto[lst_catalogo.SelectedIndex].Prod;
                ((Editar)(Grid1.Children[0])).tb_director_e.Text = conjunto[lst_catalogo.SelectedIndex].Dir;
                ((Editar)(Grid1.Children[0])).tb_temporadas_e.Text = conjunto[lst_catalogo.SelectedIndex].Temp.ToString();
                ((Editar)(Grid1.Children[0])).tb_año_e.Text = conjunto[lst_catalogo.SelectedIndex].Año.ToString();
                ((Editar)(Grid1.Children[0])).cb_rating_e.Text = conjunto[lst_catalogo.SelectedIndex].Rat.ToString();
            }
            lst_catalogo.Items.Refresh();
        }

        private void Btn_cancelar_Click(object sender, RoutedEventArgs e)
        {
            Grid1.Children.Clear();

            edicion.Visibility = Visibility.Hidden;
            Nuevo.Visibility = Visibility.Visible;
            AZ.Visibility = Visibility.Visible;
            Za.Visibility = Visibility.Visible;
            Año_mayor.Visibility = Visibility.Visible;
            Año_menor.Visibility = Visibility.Visible;
            btn_cancelar.Visibility = Visibility.Hidden;
            btn_guardar.Visibility = Visibility.Hidden;
            una.Visibility = Visibility.Hidden;
            dos.Visibility = Visibility.Hidden;
            tres.Visibility = Visibility.Hidden;
            cuatro.Visibility = Visibility.Hidden;
            cinco.Visibility = Visibility.Hidden;
        }

        private void AZ_Click(object sender, RoutedEventArgs e)
        {
            bool swap;


            do
            {
                swap = false;
                for (int index = 0; index < (conjunto.Count - 1); index++)
                {
                    if (string.Compare(conjunto[index].Tit, conjunto[index + 1].Tit) > 0)
                    {
                        var temp = conjunto[index];
                        conjunto[index] = conjunto[index + 1];
                        conjunto[index + 1] = temp;
                        swap = true;
                    }

                }
            } while (swap == true);
        }

        private void Za_Click(object sender, RoutedEventArgs e)
        {
            bool swap;


            do
            {
                swap = false;
                for (int index = 0; index < (conjunto.Count - 1); index++)
                {
                    if (string.Compare(conjunto[index].Tit, conjunto[index + 1].Tit) < 0)
                    {
                        var temp = conjunto[index];
                        conjunto[index] = conjunto[index + 1];
                        conjunto[index + 1] = temp;
                        swap = true;
                    }

                }
            } while (swap == true);
        }

        private void Btn_actualizar_Click(object sender, RoutedEventArgs e)
        {
            conjunto[lst_catalogo.SelectedIndex].Tit = ((Editar)(Grid1.Children[0])).tb_nombre_e.Text;
            conjunto[lst_catalogo.SelectedIndex].Gen = ((Editar)(Grid1.Children[0])).cb_genero_e.Text;
            conjunto[lst_catalogo.SelectedIndex].Sin = ((Editar)(Grid1.Children[0])).tb_sinopsis_e.Text;
            conjunto[lst_catalogo.SelectedIndex].Prod = ((Editar)(Grid1.Children[0])).tb_productor_e.Text;
            conjunto[lst_catalogo.SelectedIndex].Dir = ((Editar)(Grid1.Children[0])).tb_director_e.Text;
            conjunto[lst_catalogo.SelectedIndex].Temp = Convert.ToInt32(((Editar)(Grid1.Children[0])).tb_temporadas_e.Text);
            conjunto[lst_catalogo.SelectedIndex].Año = Convert.ToInt32(((Editar)(Grid1.Children[0])).tb_año_e.Text);
            conjunto[lst_catalogo.SelectedIndex].Rat  = Convert.ToInt32(((Editar)(Grid1.Children[0])).cb_rating_e.Text);
        }

        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {
            if(lst_catalogo.SelectedIndex != -1)
            {
                conjunto.RemoveAt(lst_catalogo.SelectedIndex);
                Grid1.Children.Clear();
                una.Visibility = Visibility.Hidden;
                dos.Visibility = Visibility.Hidden;
                tres.Visibility = Visibility.Hidden;
                cuatro.Visibility = Visibility.Hidden;
                cinco.Visibility = Visibility.Hidden;
                btn_delete.Visibility = Visibility.Hidden;
                btn_actualizar.Visibility = Visibility.Hidden;
                btn_cancelar.Visibility = Visibility.Hidden;
            }
        }

        private void Año_mayor_Click(object sender, RoutedEventArgs e)
        {
            bool proceso = false;
            do
            {
                proceso = false;
                for (int i = 0; i < conjunto.Count - 1; i++)
                {
                    if (conjunto[i].Año < conjunto[i + 1].Año)
                    {
                        var temp = conjunto[i];
                        conjunto[i] = conjunto[i + 1];
                        conjunto[i + 1] = temp;
                        proceso = true;
                    }
                }
            }
            while (proceso);

        }

        private void Año_menor_Click(object sender, RoutedEventArgs e)
        {
            bool proceso = false;
            do
            {
                proceso = false;
                for (int i = 0; i < conjunto.Count - 1; i++)
                {
                    if (conjunto[i].Año > conjunto[i + 1].Año)
                    {
                        var temp = conjunto[i];
                        conjunto[i] = conjunto[i + 1];
                        conjunto[i + 1] = temp;
                        proceso = true;
                    }
                }
            }
            while (proceso);
        }
    }

    
}


