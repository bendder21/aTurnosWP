using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace PruebaAturnos
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
         //   WebBrowserTask pruebaweb = new WebBrowserTask();
         //   pruebaweb.Uri = new Uri("www.aturnos.com/indexm.php");
         //   pruebaweb.Show();
            
            navegador.Navigate(new Uri("http://www.aturnos.com/indexm.php"));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            navegador.Navigate(new Uri("http://www.marca.com"));
            System.Diagnostics.Debug.WriteLine("llega a este puntoOOOO");
            System.Diagnostics.Debug.WriteLine("Añado esto");
           //haciendo algun cambio
        }

    
    }
}