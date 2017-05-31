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
            SharedCodeTest values = new SharedCodeTest(1, "Clicked me!");
            theButton.Clicked += (sender, args) =>
            {
                
                theButton.Text = String.Format("Clicked me {0} times",values.getNumber());
            };

            this.Content = theButton;
              
            

        }
    }
}
