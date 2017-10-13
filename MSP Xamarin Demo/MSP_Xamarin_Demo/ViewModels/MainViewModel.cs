using MSP_Xamarin_Demo.Helpers;
using MSP_Xamarin_Demo.Models;
using System.Threading.Tasks;
using MSP_Xamarin_Demo.Services;
using System.Windows.Input;
using System;

namespace MSP_Xamarin_Demo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableRangeCollection<BingImage> BingImageCollection { get; set; }

        private bool _IsLoading;

        public bool IsLoading
        {
            get { return _IsLoading; }
            set { Set(ref _IsLoading, value); }
        }

        public MainViewModel()
        {
            BingImageCollection = new ObservableRangeCollection<BingImage>();
        }

        public async Task LoadImagesAsync()
        {
            IsLoading = true;
            BingImageCollection.Clear();
            var list = await BingImageService.GetBingImagesAsync(8);
            BingImageCollection.AddRange(list);
            IsLoading = false;
        }

        private ICommand _LoadImagesCommand;

        public ICommand LoadImagesCommand
        {
            get
            {
                return new RelayCommand<EventArgs>(async (e) =>
                {
                    await LoadImagesAsync();
                });
            }
            set { _LoadImagesCommand = value; }
        }
    }
}
