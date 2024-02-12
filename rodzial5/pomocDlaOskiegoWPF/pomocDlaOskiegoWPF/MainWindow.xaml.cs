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

namespace pomocDlaOskiegoWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random random = new Random();
        swordDamage SwordDamage;
        public MainWindow()
        {
            InitializeComponent();
            SwordDamage = new swordDamage(random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7));

            RollDice();
        }

        public void RollDice()
        {
            SwordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            DisplayDamage();
            
        }

        private void DisplayDamage()
        {
            damage.Text = "Rzut: " + SwordDamage.Roll + ", punkty obrażeń: " + SwordDamage.Damage;
        }

        private void magic_Checked(object sender, RoutedEventArgs e)
        {
            SwordDamage.Magic = true;
            DisplayDamage();
        }

        private void flaming_Checked(object sender, RoutedEventArgs e)
        {
            SwordDamage.Flaming = true;
            DisplayDamage();
        }

        private void flaming_Unchecked(object sender, RoutedEventArgs e)
        {
            SwordDamage.Flaming = false;
            DisplayDamage();
        }

        private void magic_Unchecked(object sender, RoutedEventArgs e)
        {
            SwordDamage.Magic = false;
            DisplayDamage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RollDice();
        }
    }
}
