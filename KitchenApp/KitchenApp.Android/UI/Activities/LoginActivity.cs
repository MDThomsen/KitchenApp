using Android.App;
using Android.OS;
using Android.Content.PM;
using KitchenApp.Droid.UI.Fragments;

namespace KitchenApp.Droid.UI.Activities
{
    [Activity(Label = "LoginActivity", ScreenOrientation = ScreenOrientation.Portrait)]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.login_activity);

            var ft = this.FragmentManager.BeginTransaction();
            var lf = LoginFragment.NewInstance();
            ft.Add(Resource.Id.fragment_container, lf);
            ft.Commit();
        }
    }
}