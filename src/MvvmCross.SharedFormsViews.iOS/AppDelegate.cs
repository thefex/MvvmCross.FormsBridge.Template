using Foundation;
using MvvmCross.Platforms.Ios.Core;
using MvvmCross.SharedFormsViews.Core;
using UIKit;

namespace MvvmCross.SharedFormsViews.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            Xamarin.Forms.Forms.Init();
            return base.FinishedLaunching(application, launchOptions);
        }
    }
}
