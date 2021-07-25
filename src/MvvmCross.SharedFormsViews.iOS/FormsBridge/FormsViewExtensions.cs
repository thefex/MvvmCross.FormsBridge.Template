using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace MvvmCross.SharedFormsViews.iOS.FormsBridge
{
    public static class FormsViewControllerExtensions
    {
        public static UIViewController Build(this ContentPage fromContentPage)
        {
            var renderer = Platform.CreateRenderer(fromContentPage) as PageRenderer;

            return renderer;
        }
    }
}
