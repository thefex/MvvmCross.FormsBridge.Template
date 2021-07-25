# MvvmCross.FormsBridge.Template
This is a project/template (based on official Mvx template) with base classes that allows you to mix native MvvmCross with some views implemented via Forms (XAML). 

You can write your regular native app and add some custom views written in Forms/XAML (for ex. menu views, subviews etc..)
You can them reuse them as ViewControllers or Fragments/Activities - with MvvmCross interop.

Load solution and test Droid/iOS projects.

# How to add Forms view to your Mvx app?
1. Create Xamarin Forms library where you will hold your xaml's/pages.
2. Copy MvxFormsViewController/MvxFormsActivity/MvxFormsFragment classes to your projects - and add Xamarin.Forms.Forms.Init(..) like in sample apps.
3. Use inhertaince - if you add MainPage to iOS project -> inherit from MvxFormsViewController<MainPage, MainPageViewModel>, in case of android use: MvxFormsFragment<MainPage, MainPageViewModel> / MvxFormsActivity<MainPage, MainPageViewModel>

Take a note that all of the Fragment/ViewController/Activity presentation attributes works.

# CAUTION
This is a proof of concept. Not tested in production env. but my future apps will use that - so you might expect updates in future.
