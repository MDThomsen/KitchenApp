﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;


namespace KitchenApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new KitchenApp.MainPage();
            KitchenApp.Core.Tables.Meal test;






        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
