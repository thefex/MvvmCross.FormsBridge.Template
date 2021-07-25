using System;
using Foundation;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.SharedFormsViews.Core.ViewModels.Main;
using MvvmCross.SharedFormsViews.SharedViews;

namespace MvvmCross.SharedFormsViews.iOS.Views.Main
{
    [MvxChildPresentation]
    public class MainPageFormsViewController : MvxFormsViewController<MainPage, MainPageViewModel>
    {
        public MainPageFormsViewController()
        {
        }

        public MainPageFormsViewController(NSCoder coder) : base(coder)
        {
        }

        public MainPageFormsViewController(string nibName, NSBundle bundle) : base(nibName, bundle)
        {
        }

        public MainPageFormsViewController(NSObjectFlag t) : base(t)
        {
        }

        public MainPageFormsViewController(IntPtr handle) : base(handle)
        {
        }
    }
}
