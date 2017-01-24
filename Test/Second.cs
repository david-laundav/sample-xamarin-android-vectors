using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace VectorDrawables
{
    [Activity(Label = "VectorDrawables")]
    public class Second : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            AppCompatDelegate.CompatVectorFromResourcesEnabled = true;

            SetContentView(Resource.Layout.Second);
        }
    }
}
