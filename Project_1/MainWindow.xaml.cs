/*
 * Project_1: This program compares the speed limit to the travel speed and sends a warning to the user depending on travel speed
 * Name: Spencer Unitt
 * Module: Lab Week 5
 * Problem Statement: Create a program that checks the speed and sends a color as a warning
 * 
 * Algorithm: 
 *  1. Create an int equal to the information in the speed box
 *  2. Create an int equal to the information in the travel box
 *  3. Create a third int equal to the step 2 int - the step 1 int
 *  4. Compare the ints and determine what message to print. 
 *     If the user is traveling 5 miles over the limit, set the canvas to a yellow color and tell user to slow down
 *     If the user is traveling over the speed limit send a red color with a ticket message
 *     If the user is under the speed limit then send a green color and positive message back
 */


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
            // Pulls the information needed from the textboxes
            int speed = int.Parse(speed_limit.Text);
            int travel = int.Parse(travel_speed.Text);
            int speeding = travel - speed;

            // Compares the speed limit to the travel speed and determines the warning to give out
            if(speeding <= 5 && speeding > 0)
            {
                // Alters the color depending on the code block it executes
                danger_zone.Background = Brushes.Yellow;
                // Sends a warning message to a textblock
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
            // Exits the program if the user clicks the exit button
            this.Close();
        }
    }
}
