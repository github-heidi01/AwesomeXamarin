using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeXamarin
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            CountHere.Text = $"You clicked {count} times.";
        }
    }
}
