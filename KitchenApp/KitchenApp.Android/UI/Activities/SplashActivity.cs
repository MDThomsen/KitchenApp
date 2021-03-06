﻿using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace KitchenApp.Droid.UI.Activities
{
    [Activity(Label = "SplashActivity", Theme = "@style/SplashTheme", MainLauncher = true, Icon = "@drawable/ivlogo" , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            OverridePendingTransition(Resource.Animation.slide_in, Resource.Animation.slide_out);

            Intent intent = new Intent(this, typeof(LoginActivity));
            StartActivity(intent); 
            Finish();
            base.OnCreate(savedInstanceState);
        }

    }
}