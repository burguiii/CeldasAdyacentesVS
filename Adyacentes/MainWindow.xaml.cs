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

namespace Adyacentes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int estado_celda_NO = 0;
        int estado_celda_NE = 0;
        int estado_celda_SO = 0;
        int estado_celda_SE = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click_NO(object sender, RoutedEventArgs e)
        {
            estado_celda_NO = CambiarImagen(btn_NO, estado_celda_NO);
            //Cambiar adyacentes
            estado_celda_NE = CambiarImagen(btn_NE, estado_celda_NE);
            estado_celda_SO = CambiarImagen(btn_SO, estado_celda_SO);
        }
        private void Click_NE(object sender, RoutedEventArgs e)
        {
            estado_celda_NE = CambiarImagen(btn_NE, estado_celda_NE);
            //Cambiar adyacentes
            estado_celda_NO = CambiarImagen(btn_NO, estado_celda_NO);
            estado_celda_SE = CambiarImagen(btn_SE, estado_celda_SE);
        }
        private void Click_SO(object sender, RoutedEventArgs e)
        {
            estado_celda_SO = CambiarImagen(btn_SO, estado_celda_SO);
            //Cambiar adyacentes
            estado_celda_NO = CambiarImagen(btn_NO, estado_celda_NO);
            estado_celda_SE = CambiarImagen(btn_SE, estado_celda_SE);
        }
        private void Click_SE(object sender, RoutedEventArgs e)
        {
            estado_celda_SE = CambiarImagen(btn_SE, estado_celda_SE);
            //Cambiar adyacentes
            estado_celda_SO = CambiarImagen(btn_SO, estado_celda_SO);
            estado_celda_NE = CambiarImagen(btn_NE, estado_celda_NE);
        }
        private int CambiarImagen(Button celda_objetivo, int estado)
        {
            ImageBrush brush = new ImageBrush();
            if (estado == 0)
            {
                estado = 1;
                brush.ImageSource =
              new BitmapImage(new Uri("celda_fuego.png", UriKind.Relative));
            }
            else
            {
                estado = 0;
                brush.ImageSource =
              new BitmapImage(new Uri("celda_piedra.jpg", UriKind.Relative));
            }
            celda_objetivo.Background = brush;
            return estado;
        }


    }
}
