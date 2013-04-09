using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using ExifLib;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using WP8TestApp.Resources;

namespace WP8TestApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var task = new PhotoChooserTask();
            task.Completed += task_Completed;
            task.Show();
        }

        void task_Completed(object sender, PhotoResult e)
        {
            var jpeginfo = ExifReader.ReadJpeg(e.ChosenPhoto);
            this.DataContext = jpeginfo;
        }
    }
}