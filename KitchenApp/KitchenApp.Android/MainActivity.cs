using Android.App;
using Android.Content.PM;
using Android.OS;
using KitchenApp.Droid.Controller;

namespace KitchenApp.Droid
{
    [Activity(Label = "KitchenApp", Icon = "@drawable/icon", Theme = "@style/Theme.AppCompat", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            KitchenApp.Database.Meal meal = new MainController().getMealById("0472F251-7BB6-9B73-FF0E-79A9CE77DE00").Result;
        }
    }
}

