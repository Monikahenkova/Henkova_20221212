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

        }


        private void Button_Click0(object sender, RoutedEventArgs e)
        {


        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {

        }

    }
}