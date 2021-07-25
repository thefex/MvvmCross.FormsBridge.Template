using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;

namespace MvvmCross.SharedFormsViews.Droid.Views.Splash
{
    [Activity(
        NoHistory = true,
        MainLauncher = true,
        Label = "@string/app_name",
        Theme = "@style/AppTheme.Splash",
        Icon = "@mipmap/ic_launcher",
        RoundIcon = "@mipmap/ic_launcher_round")]
    public class SplashActivity : MvxSplashScreenActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            if (!Xamarin.Forms.Forms.IsInitialized)
                Xamarin.Forms.Forms.Init(this, bundle);
            base.OnCreate(bundle);
        }
    }
}
