using Android.OS;
using Android.Views;
using MvvmCross.Platforms.Android.Views.Fragments;
using MvvmCross.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using View = Android.Views.View;

namespace MvvmCross.SharedFormsViews.Droid.Views
{
    public abstract class MvxFormsFragment<TPage, TViewModel> : MvxFragment<TViewModel>
        where TViewModel : class, IMvxViewModel
        where TPage : ContentPage, new()
    {

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            TPage page = new TPage() { BindingContext = ViewModel };
            var fragment = page.CreateSupportFragment(Context);

            // Hack - just need it to get Forms-built ViewGroup, could also use reflection to bypass internal constructors but... this probably does not have much overhead anyway
            // params are not used by this method - so can pass null there
            var contentView = fragment.OnCreateView(null, null, null);
            return contentView;
        }
    }
}
