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
using System.Windows.Media.Media3D.Converters;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Henkova_20221212
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Soldier jedna;
        Soldier dva;

        public MainWindow()
        {
            InitializeComponent();

            jedna = new Soldier();
            jedna.Name = "Jedna";
            Zobraz(jedna, txt1);

            dva = new Soldier();
            dva.Name = "Dva";
            Zobraz(dva, txt2);
        }

        public void Zobraz(Soldier soldier, TextBox textBox)
        {
            textBox.Text = soldier.Name + "\n";
            textBox.Text += "HP: " + soldier.HP.ToString() + "\n";
            textBox.Text += "Shield: " + soldier.Shield.ToString() + "\n";
            textBox.Text += "Level: " + soldier.Level.ToString() + "\n";
            textBox.Text += "Result:" + soldier.Result.ToString() + "\n";
        }

        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            dva.Bojovat();
            
            Zobraz(dva, txt2);

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            jedna.LecitSe();

            Zobraz(jedna, txt1);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            jedna.ZvysitLevel();

            Zobraz(jedna, txt1);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            jedna.Bojovat();

            Zobraz(jedna, txt1);
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            dva.LecitSe();

            Zobraz(dva, txt2);

        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            dva.ZvysitLevel();

            Zobraz(dva, txt2);
        }
    }
}