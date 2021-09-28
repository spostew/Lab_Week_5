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

namespace Project_1
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

        private void checker_Click(object sender, RoutedEventArgs e)
        {
            int speed = int.Parse(speed_limit.Text);
            int travel = int.Parse(travel_speed.Text);
            int speeding = travel - speed;

            if(speeding <= 5 && speeding > 0)
            {
                danger_zone.Background = Brushes.Yellow;
                message.Text = "Currently testing the limits. Slow down.";
            }
            else if(travel > speed)
            {
                danger_zone.Background = Brushes.Red;
                message.Text = "Going to fast. Slow down or get a ticket!";
            }
            else if(travel < speed)
            {
                danger_zone.Background = Brushes.Green;
                message.Text = "Going the speed limit. Currently safe";
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
