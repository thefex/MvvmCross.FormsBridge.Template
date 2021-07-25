using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace MvvmCross.SharedFormsViews.Core.ViewModels.Main
{
    public class MainPageActivityTestViewModel : MvxViewModel
    {
        private int counter = 1;
        private string _title = "Welcome From Xamarin Forms from MvvmCross - this is Activity test (0)";

        public string Title => $"Welcome From Xamarin Forms from MvvmCross - this is Activity test ({counter} times) - Forms apps - NO, lol! Forms apps with MvvmCross to speed-up when we develop eazy views - YES, COULD BE SIR";

        public MvxCommand UpdateText => new MvxCommand(() =>
        {
            counter++;
            RaisePropertyChanged(nameof(Title));
        });
    }
}
