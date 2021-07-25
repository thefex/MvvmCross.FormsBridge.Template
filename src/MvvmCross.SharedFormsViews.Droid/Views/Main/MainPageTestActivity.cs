using Android.App;
using Android.Views;
using MvvmCross.SharedFormsViews.Core.ViewModels.Main;
using MvvmCross.SharedFormsViews.SharedViews;

namespace MvvmCross.SharedFormsViews.Droid.Views.Main
{
    [Activity(
        Theme = "@style/AppTheme",
        WindowSoftInputMode = SoftInput.AdjustResize | SoftInput.StateHidden)]
    public class MainPageTestActivity : MvxFormsActivity<MainPage, MainPageActivityTestViewModel>
    {
        
    }
}
