using System;
using Cirrious.FluentLayouts.Touch;
using Foundation;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.SharedFormsViews.iOS.FormsBridge;
using MvvmCross.ViewModels;
using UIKit;
using Xamarin.Forms;

namespace MvvmCross.SharedFormsViews.iOS.Views
{
    public abstract class MvxFormsViewController<TContentPage, TViewModel> : MvxViewController<TViewModel>
        where TViewModel : class, IMvxViewModel
        where TContentPage : ContentPage, new()
    {
        protected MvxFormsViewController()
        {
        }

        protected MvxFormsViewController(NSCoder coder) : base(coder)
        {
        }

        protected MvxFormsViewController(string nibName, NSBundle bundle) : base(nibName, bundle)
        {
        }

        protected MvxFormsViewController(NSObjectFlag t) : base(t)
        {
        }

        protected MvxFormsViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.Blue;

            var page = new TContentPage() { BindingContext = ViewModel };
            var pageViewController = page.CreateViewController();

            pageViewController.WillMoveToParentViewController(this);

            Add(pageViewController.View);
            AddChildViewController(pageViewController);

            pageViewController.DidMoveToParentViewController(this);

            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            View.AddConstraints(
                    pageViewController.View.AtTopOfSafeArea(View),
                    pageViewController.View.AtBottomOf(View),
                    pageViewController.View.AtLeftOfSafeArea(View),
                    pageViewController.View.AtRightOfSafeArea(View)
                );
        }
    }
}
