using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Cirrious.FluentLayouts.Touch;
using Foundation;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.SharedFormsViews.Core.ViewModels.Main;
using UIKit;

namespace MvvmCross.SharedFormsViews.iOS.Views.Main
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public class MainViewController : BaseViewController<MainViewModel>
    {
        private UILabel _labelWelcome, _labelMessage;
        private UIButton testButton = new UIButton();

        protected override void CreateView()
        {
            _labelWelcome = new UILabel {Text = "Welcome!!", TextAlignment = UITextAlignment.Center};
            Add(_labelWelcome);

            _labelMessage = new UILabel
            {
                Text = "App scaffolded with MvxScaffolding", TextAlignment = UITextAlignment.Center
            };
            Add(_labelMessage);

            testButton = new UIButton();
            testButton.SetTitle("Test Forms Bridge", UIControlState.Normal);
            testButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
            Add(testButton);
        }

        protected override void LayoutView()
        {
            View.AddConstraints(new FluentLayout[]
            {
                _labelWelcome.WithSameCenterX(View), _labelWelcome.WithSameCenterY(View),
                _labelMessage.Below(_labelWelcome, 10f), _labelMessage.WithSameWidth(View),
                testButton.AtLeftOf(View, 24), testButton.AtRightOf(View, 24), testButton.Below(_labelMessage, 12)
            });
        }

        protected override void BindView()
        {
            base.BindView();

            var set = this.CreateBindingSet();

            set.Bind(testButton)
                .To(x => x.TestForms);

            set.Apply();
        }
    }
}
