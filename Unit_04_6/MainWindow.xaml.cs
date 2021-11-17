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

namespace Unit_04_6
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

        private void Button_Click_dol(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(dolrate.Text);
            double sumDollar = Convert.ToDouble(dolsum.Text);
            double resDouble = rateDollar * sumDollar;
            dolresSum.Text = resDouble.ToString();
        }

        private void Button_Click_evr(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(evrrate.Text);
            double sumDollar = Convert.ToDouble(evrsum.Text);
            double resDouble = rateDollar * sumDollar;
            evrresSum.Text = resDouble.ToString();
        }

        private void Button_Click_uah(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(uahrate.Text);
            double sumDollar = Convert.ToDouble(uahsum.Text);
            double resDouble = rateDollar * sumDollar;
            uahresSum.Text = resDouble.ToString();
        }

        private void Button_Click_amd(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(amdrate.Text);
            double sumDollar = Convert.ToDouble(amdsum.Text);
            double resDouble = rateDollar * sumDollar;
            amdresSum.Text = resDouble.ToString();
        }

        private void Button_Click_Inch(object sender, RoutedEventArgs e)
        {
            double sumInch = Convert.ToDouble(inch.Text);
            double resDouble = (2.54 / 100) * sumInch;
            meterFromInch.Text = resDouble.ToString();
        }

        private void Button_Click_Foot(object sender, RoutedEventArgs e)
        {
            double sumFoot = Convert.ToDouble(foot.Text);
            double resDouble = (3.05 / 10) * sumFoot;
            meterFromFoot.Text = resDouble.ToString();
        }

        private void Button_Click_Mile(object sender, RoutedEventArgs e)
        {
            double sumMile = Convert.ToDouble(mile.Text);
            double resDouble = (1609.34 / 1) * sumMile;
            meterFromMile.Text = resDouble.ToString();
        }

        private void Button_Click_Versta(object sender, RoutedEventArgs e)
        {
            double sumVersta = Convert.ToDouble(Versta.Text);
            double resDouble = (1066.8 / 1) * sumVersta;
            meterFromVersta.Text = resDouble.ToString();
        }
    }
}
