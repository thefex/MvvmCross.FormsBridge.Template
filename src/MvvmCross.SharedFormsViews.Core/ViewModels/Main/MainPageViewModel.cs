using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmCross.SharedFormsViews.Core.ViewModels.Main
{
    public class MainPageViewModel : MvxViewModel
    {
        private int counter = 1;
        private string _title = "Welcome From Xamarin Forms from MvvmCross (0)";

        public string Title => $"Welcome From Xamarin Forms from MvvmCross ({counter} times) - Forms apps - NO, lol! Forms apps with MvvmCross to speed-up when we develop eazy views - YES, COULD BE SIR";

        public MvxCommand UpdateText => new MvxCommand(() =>
        {
            counter++;
            RaisePropertyChanged(nameof(Title));
        });
    }
}
