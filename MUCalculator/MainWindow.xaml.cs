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

namespace MUCalculator
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

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            Int32 puntosFrutaAGI;
            Int32 puntosFrutaENG;
            Int32 puntosFrutaSTR;
            Int32 puntosFrutaSTA;

            puntosFrutaAGI = int.Parse(txtFrutaAGi.Text) * int.Parse(txtRebirth.Text);

            puntosFrutaENG = int.Parse(txtFrutaENG.Text) * int.Parse(txtRebirth.Text);

            puntosFrutaSTA = int.Parse(txtFrutaSTA.Text) * int.Parse(txtRebirth.Text);

            puntosFrutaSTR = int.Parse(txtFrutaSTR.Text) * int.Parse(txtRebirth.Text);

            txtFrutaAGi.Text = puntosFrutaAGI.ToString();
            txtFrutaENG.Text = puntosFrutaENG.ToString();
            txtFrutaSTA.Text = puntosFrutaSTA.ToString();
            txtFrutaSTR.Text = puntosFrutaSTR.ToString();

            txtDisponibleAGI.Text = (int.Parse(txtFrutaAGi.Text) - int.Parse(txtAGI.Text)).ToString();

            txtDisponibleENG.Text = (int.Parse(txtFrutaENG.Text) - int.Parse(txtENG.Text)).ToString();

            txtDisponibleSTA.Text = (int.Parse(txtFrutaSTA.Text) - int.Parse(txtSTA.Text)).ToString();

            txtDisponibleSTR.Text = (int.Parse(txtFrutaSTR.Text) - int.Parse(txtSTR.Text)).ToString();

            Int32 resultadoSTR = int.Parse(txtDisponibleSTR.Text);
            Int32 needSTR = int.Parse(txtNeedSTR.Text);

            Int32 resultadoAGI = int.Parse(txtDisponibleAGI.Text);
            Int32 needAGI = int.Parse(txtNeedAGI.Text);

            Int32 resultadoENG = int.Parse(txtDisponibleENG.Text);
            Int32 needENG = int.Parse(txtNeedENG.Text);

            Int32 resultadoSTA = int.Parse(txtDisponibleSTA.Text);
            Int32 needSTA = int.Parse(txtNeedSTA.Text);


            if (resultadoSTR >= needSTR)
            {
                lblSTR.Content = "OK";
                lblSTR.Background = Brushes.LawnGreen;
                txtDisponibleSTR.Background = Brushes.LawnGreen;
            }
            else
            {
                lblSTR.Content = "NO";
                lblSTR.Background = Brushes.Red;
                txtDisponibleSTR.Background = Brushes.Red;
            }

            if (resultadoAGI >= needAGI)
            {
                lblAGI.Content = "OK";
                lblAGI.Background = Brushes.LawnGreen;
                txtDisponibleAGI.Background = Brushes.LawnGreen;
            }
            else
            {
                lblAGI.Content = "NO";
                lblAGI.Background = Brushes.Red;
                txtDisponibleAGI.Background = Brushes.Red;
            }

            if (resultadoENG >= needENG)
            {
                lblENG.Content = "OK";
                lblENG.Background = Brushes.LawnGreen;
                txtDisponibleENG.Background = Brushes.LawnGreen;
            }
            else
            {
                lblENG.Content = "NO";
                lblENG.Background = Brushes.Red;
                txtDisponibleENG.Background = Brushes.Red;
            }

            if (resultadoSTA >= needSTA)
            {
                lblSTA.Content = "OK";
                lblSTA.Background = Brushes.LawnGreen;
                txtDisponibleSTA.Background = Brushes.LawnGreen;
            }
            else
            {
                lblSTA.Content = "NO";
                lblSTA.Background = Brushes.Red;
                txtDisponibleSTA.Background = Brushes.Red;
            }



        }
    }
}
