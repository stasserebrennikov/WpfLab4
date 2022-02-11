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

namespace WpfLab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();


        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            double i = 0.254;
            double rateInch = Convert.ToDouble(rate1.Text);
            double resInch = rateInch * i;
            resSum1.Text = resInch.ToString();


        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            double i = 0.3048;
            double rateFut = Convert.ToDouble(rate5.Text);
            double resFut = rateFut * i;
            resSum5.Text = resFut.ToString();


        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            double i = 1609.34;
            double rateMili = Convert.ToDouble(rate6.Text);
            double resMili = rateMili * i;
            resSum6.Text = resMili.ToString();


        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            double i = 1066.8;
            double rateVerst = Convert.ToDouble(rate7.Text);
            double resVerst = rateVerst * i;
            resSum7.Text = resVerst.ToString();


        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate2.Text);
            double sumEuro = Convert.ToDouble(sum2.Text);
            double resEuro = rateEuro * sumEuro;
            resSum2.Text = resEuro.ToString();
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            double rateLari = Convert.ToDouble(rate3.Text);
            double sumLari = Convert.ToDouble(sum3.Text);
            double resLari = rateLari * sumLari;
            resSum3.Text = resLari.ToString();
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            double rateGriv = Convert.ToDouble(rate4.Text);
            double sumGriv = Convert.ToDouble(sum4.Text);
            double resGriv = rateGriv * sumGriv;
            resSum4.Text = resGriv.ToString();
        }
    }
}
