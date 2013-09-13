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

using Microsoft.Phone.Shell;


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
            //
            //no
            
            
            ApplicationBar = new ApplicationBar();

            ApplicationBar.Mode = ApplicationBarMode.Default;
            ApplicationBar.Opacity = 1.0;
            ApplicationBar.IsVisible = true;
            ApplicationBar.IsMenuEnabled = true;
            

            ApplicationBarIconButton button1 = new ApplicationBarIconButton();
           button1.IconUri = new Uri("/iconos/close.png", UriKind.Relative);
            button1.Text = "Home";
            ApplicationBar.Buttons.Add(button1);

            ApplicationBarIconButton button2 = new ApplicationBarIconButton();
           button2.IconUri = new Uri("/iconos/mail.png", UriKind.Relative);
            button2.Text = "Cuadrante";
            ApplicationBar.Buttons.Add(button2);

            ApplicationBarIconButton button3 = new ApplicationBarIconButton();
          button3.IconUri = new Uri("/Images/YourImage.png", UriKind.Relative);
            button3.Text = "Compañeros";
            ApplicationBar.Buttons.Add(button3);

            ApplicationBarIconButton button4 = new ApplicationBarIconButton();
           button4.IconUri = new Uri("/Images/YourImage.png", UriKind.Relative);
            button4.Text = "Agenda";
            ApplicationBar.Buttons.Add(button4);

           

            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);
            button4.Click += new EventHandler(button4_Click);

            ApplicationBarMenuItem menuItem1 = new ApplicationBarMenuItem();
            menuItem1.Text = "Web";
            ApplicationBar.MenuItems.Add(menuItem1);

            ApplicationBarMenuItem menuItem2 = new ApplicationBarMenuItem();
            menuItem2.Text = "Salir";
            ApplicationBar.MenuItems.Add(menuItem2);

            menuItem1.Click += new EventHandler(menuItem1_Click);
            menuItem2.Click += new EventHandler(menuItem2_Click);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Button 1 works!");
            navegador.Navigate(new Uri("http://www.aturnos.com/indexm.php"));
            //Do work for your application here.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Button 1 works!");
            navegador.Navigate(new Uri("http://www.aturnos.com/indexm.php"));
            //Do work for your application here.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Button 1 works!");
            navegador.Navigate(new Uri("http://www.aturnos.com/indexm.php"));
            //Do work for your application here.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Button 1 works!");
            navegador.Navigate(new Uri("http://www.aturnos.com/indexm.php"));
            //Do work for your application here.
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu item 1 works!");
            //Do work for your application here.
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu item 1 works!");
            //Do work for your application here.
        }

    
    }
}