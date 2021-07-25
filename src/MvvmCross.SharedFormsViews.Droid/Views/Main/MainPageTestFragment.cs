using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.SharedFormsViews.Core.ViewModels.Main;
using MvvmCross.SharedFormsViews.SharedViews;

namespace MvvmCross.SharedFormsViews.Droid.Views.Main
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame)]
    public class MainPageTestFragment : MvxFormsFragment<MainPage, MainPageViewModel>
    {

    }
}
