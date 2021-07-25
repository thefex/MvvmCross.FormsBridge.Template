using Android.OS;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace MvvmCross.SharedFormsViews.Droid.Views
{
    public abstract class MvxFormsActivity<TPage, TViewModel> : MvxActivity<TViewModel>
        where TViewModel : class, IMvxViewModel
        where TPage : ContentPage, new()
    {
        protected override void OnCreate(Bundle bundle)
        {
            if (!Xamarin.Forms.Forms.IsInitialized)
                Xamarin.Forms.Forms.Init(this, bundle);
            base.OnCreate(bundle);

            TPage page = new TPage() { BindingContext = ViewModel };
            var fragment = page.CreateSupportFragment(this);

            // Hack - just need it to get Forms-built ViewGroup, could also use reflection to bypass internal constructors but... this probably does not have much overhead anyway
            // params are not used by this method - so can pass null there
            var contentView = fragment.OnCreateView(null, null, null);
            SetContentView(contentView);
        }
    }
}
