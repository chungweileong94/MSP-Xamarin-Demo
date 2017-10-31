# MSP-Xamarin-Demo
MSP Xamarin form app with .NET standard 2.0


.NET Standard 2.0 (step)
==========================
- Create a new .net standard library
    - Remove unnecessary file (Class1.cs)
- Install Nuget package to the library
    - Xamarin Form
    - Microsoft.NETCore.Portable.Compatibility
    - make sure all others platform having latest Xamarin Form nuget package
    - UWP project need to update it's own package to v6.0.+
- Move files from old portable library to new library
    - App.xaml & App.xaml.cs
    - MainPage.xaml & MainPage.xaml.cs
- Remove old library
- Rename standard library namespace
- Add reference to all platform

MVVM (step)
==========================
- Create few folders
    - Views
    - ViewModels
    - Models
    - Services
    - Helpers

- Move the MainPage.xaml & MainPage.xaml.cs to Views
    - Modify the namespace to "Views"
- Change the MainPage link in App.xaml.cs
- Add MainViewModel.cs and BaseViewModel to ViewModels
- Add BingImage.cs and ImageCollection.cs in Models folder
- Add BingImageService.cs in Service folder
- Add RelayCommand.cs to Helpers folder
- Link between MainViewModel.cs to MainPage

Performance Tips
==========================
- Xamarin Form nuget package
- Xaml Compilation
- Xamarin Form Android Fast Renderer
- ObservableRangeCollection
