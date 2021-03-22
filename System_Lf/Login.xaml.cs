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

namespace System_Lf
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

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();

            }
            catch (Exception)
            {

               
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            if (txtuser.Text != "Usuario")
            {
                if (txtpass.Password != "Contraseña")
                {
                    Usuarios user = new Usuarios();
                    var validLogin = user.login_user(txtuser.Text, txtpass.Password);
                    if (validLogin == true && txtuser.Text == Cache_Usuario.Usuario && txtpass.Password == Cache_Usuario.Contra)
                    {

                        MessageBox.Show("Bienvenido!");
                    }
                    else
                    {
                        MessageBox.Show("Usuario Incorrecto o Contraseña\nIntente de nuevo");
                    
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Ingrese su Contraseña");
                }

            }
            else
            {
                MessageBox.Show("Por Favor Ingrese su Usuario");
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
