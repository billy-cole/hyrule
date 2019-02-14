using System;
using System.Net.Http;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

namespace OwlBotDictionary
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WordPage : ContentPage
	{
        public string WordToSearch { get; set; }

		public WordPage (string wordToSearch)
		{
			InitializeComponent();
            WordToSearch = wordToSearch;
            GetWordInfo();
            
		}

        private async void GetWordInfo()
        {
            var client = new HttpClient();
            var owlBotUrl = "https://owlbot.info/api/v2/dictionary/" + WordToSearch;
            var uri = new Uri(owlBotUrl);

            var wordInfoList = new List<Word>();

            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var jsonContent = await response.Content.ReadAsStringAsync();

                wordInfoList = JsonConvert.DeserializeObject<List<Word>>(jsonContent);

                if (wordInfoList.Count == 0)
                {
                    await DisplayAlert("ERROR", $"The word {WordToSearch} does not exist or cannot be found.", "OK");
                    await Navigation.PopAsync();
                }
            }

            WordInfoListView.ItemsSource = wordInfoList;
        }
    }
}