using UIKit;

namespace MvvmCross.SharedFormsViews.iOS
{
    public static class Application
    {
        private static void Main(string[] args)
        {
            UIApplication.Main(args, null, nameof(AppDelegate));
        }
    }
}
