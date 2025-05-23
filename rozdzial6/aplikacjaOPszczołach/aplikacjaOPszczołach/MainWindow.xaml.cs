﻿using System;
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
using System.Windows.Threading;

namespace aplikacjaOPszczołach
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        private DispatcherTimer timer = new DispatcherTimer();

        private readonly Queen queen;
        public MainWindow()
        {
            InitializeComponent();
            queen = Resources["queen"] as Queen;
            // statusReport.Text = queen.StatusReport;
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(1.5);
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            WorkShift_Click(this, new RoutedEventArgs());
        }
        private void AssignJob_Click(object sender, RoutedEventArgs e)
        {
            queen.AssignBee(jobSelector.Text);
            // statusReport.Text = queen.StatusReport;
        }

        private void WorkShift_Click(object sender, RoutedEventArgs e)
        {
            queen.WorkTheNextShift();
            // statusReport.Text = queen.StatusReport;
        }
    }
}
