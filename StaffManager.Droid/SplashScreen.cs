using Android.App;
using Android.Content.PM;
using Cirrious.MvvmCross.Droid.Views;

namespace StaffManager.Droid
{
    [Activity(
		Label = "StaffManager.Droid"
		, MainLauncher = true
		, Icon = "@drawable/AppIcon"
		, Theme = "@style/Theme.SplashScreen"
		, NoHistory = true
		, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}