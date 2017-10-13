using MSP_Xamarin_Demo.Models;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MSP_Xamarin_Demo.Services
{
    public abstract class BingImageService
    {
        public static async Task<List<BingImage>> GetBingImagesAsync(int number)
        {
            using (HttpClient http = new HttpClient())
            {
                string json = await http.GetStringAsync($"https://www.bing.com/HPImageArchive.aspx?format=js&n={number}");

                var imageCollection = JsonConvert.DeserializeObject<ImageCollection>(json);

                List<BingImage> bingImages = new List<BingImage>();

                foreach (var image in imageCollection.images)
                {
                    bingImages.Add(new BingImage
                    {
                        ImageUrl = "https://www.bing.com" + image.url,
                        Title = image.copyright
                    });
                }

                return bingImages;
            }
        }
    }
}
