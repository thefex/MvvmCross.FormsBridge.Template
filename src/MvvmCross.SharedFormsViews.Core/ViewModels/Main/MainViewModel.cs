using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Commands;
using MvvmCross.IoC;
using MvvmCross.Navigation;

namespace MvvmCross.SharedFormsViews.Core.ViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        public MvxCommand TestForms => new MvxCommand(() =>
        {
            MvxIoCProvider.Instance.Resolve<IMvxNavigationService>().Navigate<MainPageViewModel>();
        });

        public MvxCommand TestFormsActivity => new MvxCommand(() =>
        {
            MvxIoCProvider.Instance.Resolve<IMvxNavigationService>().Navigate<MainPageActivityTestViewModel>();
        });
    }
}
