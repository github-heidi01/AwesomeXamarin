using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace AwesomeXamarin.UWP
{
    public sealed partial class MainPage
    {
        private int count = 0;

        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new AwesomeXamarin.App());
        }

        
        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            count++;
            CountHere.Text = $"You clicked {count} times.";
        }
    }
}
