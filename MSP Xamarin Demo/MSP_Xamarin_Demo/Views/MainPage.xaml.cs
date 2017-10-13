using MSP_Xamarin_Demo.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSP_Xamarin_Demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new MainViewModel();
            BindingContext = ViewModel;

            ImageListView.ItemSelected += delegate { ImageListView.SelectedItem = null; };
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.LoadImagesAsync();
        }
    }
}