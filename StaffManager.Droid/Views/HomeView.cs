using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace StaffManager.Droid.Views
{
    [Activity(Label = "Home")]
    public class HomeView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HomeView);
        }
    }
}