﻿using MohammadDayyanCalendar;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace GuruWPF
{
    /// <summary>
    /// Interaction logic for AnalogClock.xaml
    /// </summary>
    public partial class AnalogClock : Window
    {
        System.Timers.Timer timer = new System.Timers.Timer(1000);
        public AnalogClock()
        {
            InitializeComponent();

            MDCalendar mdCalendar = new MDCalendar();
            DateTime date = DateTime.Now;
            TimeZone time = TimeZone.CurrentTimeZone;
            TimeSpan difference = time.GetUtcOffset(date);
            uint currentTime = mdCalendar.Time() + (uint)difference.TotalSeconds;
            persianCalendar.Content = mdCalendar.Date("Y/m/D  W", currentTime, true);
            christianityCalendar.Content = mdCalendar.Date("P Z/e/d", currentTime, false);

            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Enabled = true;
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke(DispatcherPriority.Normal, (Action)(() =>
            {
                secondHand.Angle = DateTime.Now.Second * 6;
                minuteHand.Angle = DateTime.Now.Minute * 6;
                hourHand.Angle = (DateTime.Now.Hour * 30) + (DateTime.Now.Minute * 0.5);
            }));
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
