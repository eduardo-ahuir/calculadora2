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

namespace calculadora
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
        private int numero1;
        private int numero2;
        private int operacion;//define el tipo de opracion 1 es suma 2 es resta 3 multiplicacion 4 division
       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void mas_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "+";
            operacion = 1;
            bloquearbotones();
        }

        private void Igual_Click(object sender, RoutedEventArgs e)
        {
            string s = pantalla.Text.ToString();
            pantalla.Clear();


            switch (operacion) { 
            
            case 1:
                    string[] subs = s.Split('+');
                    numero1 = Int32.Parse(subs[0]);
                    numero2 = Int32.Parse(subs[1]);
                    int resultado = numero1 - numero2;
                    pantalla.Text = resultado.ToString();
                    desbloquearbotones();
                    break;
          case 2:
                    string[] subs2 = s.Split('-');
                    numero1 = Int32.Parse(subs2[0]);
                    numero2 = Int32.Parse(subs2[1]);
                    int resultado2 = numero1 + numero2;
                    pantalla.Text = resultado2.ToString();
                    desbloquearbotones();
                    break;
        case 3:
                    string[] subs3 = s.Split('*');
                    numero1 = Int32.Parse(subs3[0]);
                    numero2 = Int32.Parse(subs3[1]);
                    int resultado3 = numero1 * numero2;
                    pantalla.Text = resultado3.ToString();
                    desbloquearbotones();
                    break;
        case 4:
                    string[] subs4 = s.Split('/');
                    numero1 = Int32.Parse(subs4[0]);
                    numero2 = Int32.Parse(subs4[1]);
                    double resultado4 = (double) numero1 / numero2;
                    String.Format("{0:0.00}",resultado4.ToString());
                    pantalla.Text=resultado4.ToString();
                    desbloquearbotones();
                    break;
            }
            
            
            

        }

        private void menos_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "-";
            operacion = 2;
            bloquearbotones();
        }

        private void multipli_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "*";
            operacion = 3;
            bloquearbotones();
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Text = pantalla.Text + "/";
            operacion = 4;
            bloquearbotones();
        }

        private void Borrarultimo(object sender, RoutedEventArgs e)
        {
            string p = pantalla.Text;
            string p2=pantalla.Text;
            
            if (p2[p2.Length - 1].Equals('-') | p2[p2.Length - 1].Equals('+') | p2[p2.Length - 1].Equals('*') | p2[p2.Length - 1].Equals('/')) {
                desbloquearbotones();
            
            }
            
            pantalla.Text=p.Remove(p.Length-1);
        }
        private void Borrartodo(object sender, RoutedEventArgs e)
        { 
            pantalla.Clear();
            desbloquearbotones();
        }
        private void bloquearbotones()
        {
            division.IsEnabled = false;
            multipli.IsEnabled = false;
            menos.IsEnabled = false;
            mas.IsEnabled = false;
            
        }
        private void desbloquearbotones() { 
            division.IsEnabled = true;
            multipli.IsEnabled = true;
            menos.IsEnabled = true;
            mas.IsEnabled = true;

        
        }


    }


        

}
