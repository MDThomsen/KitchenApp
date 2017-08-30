using Android.App;
using Android.Content.PM;
using Android.OS;
using KitchenApp.Database;
using KitchenApp.Droid.Controller;
using System.Threading.Tasks;

namespace KitchenApp.Droid
{
    [Activity(Label = "MainActivity", Theme = "@style/MainTheme", ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            OverridePendingTransition(Resource.Animation.slide_in, Resource.Animation.slide_out);
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            

            //Meal meal = new MainController().getMealById("0472F251-7BB6-9B73-FF0E-79A9CE77DE00").Result;
            Task.Run(() =>
            {
                 new MainController().UserLogin("mdahlthomsen@hotmail.com", "n26yb7W2");
            });
        }
    }
}

