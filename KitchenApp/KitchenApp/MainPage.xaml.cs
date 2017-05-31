using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KitchenApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            theButton.Clicked += (sender, args) =>
            {
                theButton.Text = "Touched me!";
            };

            this.Content = theButton;
              
        }
    }
}
