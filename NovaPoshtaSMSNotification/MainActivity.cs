using Android.App;
using Android.Widget;
using Android.OS;

using System;
using Android.Views;
using HockeyApp.Android;
using HockeyApp.Android.Metrics;

namespace NovaPoshtaSMSNotification
{
    [Activity(Label = "NovaPoshtaSMSNotification", MainLauncher = true)]
    public class MainActivity : Activity
    {
        // D3:6B:A8:06:44:18:B5:BA:26:0A:9B:5A:9C:40:55:8E:28:77:12:2E
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            MetricsManager.Register(Application, "92b286817c9e445186a180e51625b6cc");


            var mListView = FindViewById<ListView>(Resource.Id.listView1);
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1);
            mListView.Adapter = adapter;
            adapter.Add("test1");
            adapter.Add("test2");
            adapter.NotifyDataSetChanged();
        }

        protected override void OnResume()
        {
            base.OnResume();
            CrashManager.Register(this, "92b286817c9e445186a180e51625b6cc");
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            menu.Add(Menu.None, 0, 0, "Item 0");
            menu.Add(0, 1, 1, "Item 1");
            menu.Add(0, 2, 2, "Item 2");
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case 0:
                    //Do stuff for item 0
              
                    return true;
                case 1:
                    //Do stuff for item 1
                    //FirebaseCrash.Log("Do stuff for item 1");
                    return true;
                case 2:
                    throw new Exception("Test2!");
                    //FirebaseCrash.Log("Do stuff for item 2");
                    //Do stuff for item 2
                    return true;
                default:
                    return false;
            }
        }
    }
}

