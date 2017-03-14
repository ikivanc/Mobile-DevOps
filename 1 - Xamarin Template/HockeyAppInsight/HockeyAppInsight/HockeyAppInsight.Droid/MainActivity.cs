using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using HockeyApp.Android;
using HockeyApp.Android.Metrics;


namespace HockeyAppInsight.Droid
{
    [Activity(Label = "HockeyAppInsight", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            //HockeyApp.net adresinden aldığımız HockeyApp ID'sini ilk önce aşağıdaki belirtilen yerlere yerleştireceğiz.
            CrashManager.Register(this, "BURAYA HOCKEY APPID'İNİZ GELECEK");
            MetricsManager.Register(Application, "BURAYA HOCKEY APPID'İNİZ GELECEK");

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

