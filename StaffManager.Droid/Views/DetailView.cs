using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace StaffManager.Droid.Views
{
    [Activity(Label = "Detail of Staff")]
    public class DetailView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.DetailView);
        }
    }
}