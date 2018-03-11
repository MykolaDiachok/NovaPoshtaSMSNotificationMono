using Android.App;
using Android.Widget;
using Android.OS;

namespace NovaPoshtaSMSNotification
{
    [Activity(Label = "NovaPoshtaSMSNotification", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

