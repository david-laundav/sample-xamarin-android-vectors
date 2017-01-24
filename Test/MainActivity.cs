using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

namespace VectorDrawables
{
    [Activity(Label = "VectorDrawables", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate 
            {
                StartActivity(new Intent(this, typeof(Second)));
            };

            //var image = FindViewById<ImageView>(Resource.Id.imageView);

            //image.SetImageDrawable(ContextCompat.GetDrawable(this, Resource.Drawable.rotate));
        }
    }
}

