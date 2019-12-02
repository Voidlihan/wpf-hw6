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

namespace WPF_HW6
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

        private void BuyAll(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            sum -= Convert.ToInt32(dataGridSum.Items[1]);

        }

        private void Benzin92(object sender, RoutedEventArgs e)
        {
            int price = 100;
            int sum = price;
            for (int i = 0; i < dataGridSum.Items.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridSum.Items[i]);
            }
            textBox92.Text = sum.ToString();
        }

        private void Benzin96(object sender, RoutedEventArgs e)
        {
            int price = 200;
            int sum = price;
            for (int i = 0; i < dataGridSum.Items.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridSum.Items[i]);
            }
            textBox96.Text = sum.ToString();
        }

        private void ButtonNeskvik(object sender, RoutedEventArgs e)
        {
            int price = 50;
            int sum = price;
            for (int i = 0; i < dataGridSum.Items.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridSum.Items[i]);
            }
            textBoxNeskvik.Text = sum.ToString();
        }

        private void ButtonSnikers(object sender, RoutedEventArgs e)
        {
            int price = 50;
            int sum = price;
            for (int i = 0; i < dataGridSum.Items.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridSum.Items[i]);
            }
            textBoxSnikers.Text = sum.ToString();
        }

        private void Button5liter(object sender, RoutedEventArgs e)
        {
            int price = 70;
            int sum = price;
            for (int i = 0; i < dataGridSum.Items.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridSum.Items[i]);
            }
            textBox5liter.Text = sum.ToString();
        }

        private void Button2liter(object sender, RoutedEventArgs e)
        {
            int price = 30;
            int sum = price;
            for (int i = 0; i < dataGridSum.Items.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridSum.Items[i]);
            }
            textBox2liter.Text = sum.ToString();
        }

        private void GlassClean(object sender, RoutedEventArgs e)
        {
            int price = 80;
            int sum = price;
            for (int i = 0; i < dataGridSum.Items.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridSum.Items[i]);
            }
            textBoxGlassClean.Text = sum.ToString();
        }

        private void Diamond(object sender, RoutedEventArgs e)
        {
            int price = 90;
            int sum = price;
            for (int i = 0; i < dataGridSum.Items.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridSum.Items[i]);
            }
            textBoxDiamond.Text = sum.ToString();
        }
    }
}
