using PickACardUI;
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

namespace WPF_PickACardUI
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Random rnd = new Random();
            double[] randomDoubles = new double[20];
            for (int i = 0; i < randomDoubles.Length; i++)
            {
                double value = rnd.NextDouble();
                if(value >= 0.0 && value < 1.0)
                {
                    randomDoubles[i] = value;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] pickedCards = CardPicker.PickSomeCards((int)numberOfCards.Value);
            listOfCards.Items.Clear();
            foreach(string spucha in pickedCards) 
            {
                listOfCards.Items.Add(spucha);
            }
        }
    }
}
