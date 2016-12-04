using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace StaffManager.Droid.Views
{
    [Activity(Label = "Add a new Staff")]
    public class AddView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.AddView);
        }
    }
}