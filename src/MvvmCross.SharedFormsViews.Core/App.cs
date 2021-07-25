using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvvmCross.SharedFormsViews.Core.ViewModels.Main;

namespace MvvmCross.SharedFormsViews.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
