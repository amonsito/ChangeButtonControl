using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ControlsTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GreenButton_Clicked(object sender, EventArgs e)
        {
            //mybtn.IsEnabled = false;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            mybtn.IsEnabled = !mybtn.IsEnabled;
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            mybtn.Active= !mybtn.Active;
        }
    }
}
