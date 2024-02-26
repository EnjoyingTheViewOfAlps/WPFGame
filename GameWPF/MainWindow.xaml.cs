using Core_;
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

namespace GameWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exp(object sender, RoutedEventArgs e)
        {
            unit.Experience = unit.Experience + 1000;
            unit.TotalExp = unit.TotalExp + unit.Experience;
            unit.LevelUp();

            unit.Strength++;
            unit.Inteligence++;
            unit.Vitality++;
            unit.Dexterity++;
            unit.StartsPoints++;
            this.DataContext = unit;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (unit.Strength == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Strength--;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Strength++;
            }
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Dexterity++;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (unit.Dexterity == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Dexterity--;
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Inteligence++;
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (unit.Inteligence == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Inteligence--;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (unit.StartsPoints == 0)
                return;
            else
            {
                unit.StartsPoints--;
                unit.Vitality++;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (unit.Vitality == 0)
                return;
            else
            {
                unit.StartsPoints++;
                unit.Vitality--;
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            unit = new Warrior();

            UnitClass.Text = "Warrior";
            MyImage.Content = Resources["Warrior"];

            this.DataContext = unit;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            unit = new Wizzard();

            UnitClass.Text = "Wizzard";
            MyImage.Content = Resources["Wizzard"];

            this.DataContext = unit;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            unit = new Rogue();

            UnitClass.Text = "Rogue";
            MyImage.Content = Resources["Rogue"];

            this.DataContext = unit;
        }
    }
}
