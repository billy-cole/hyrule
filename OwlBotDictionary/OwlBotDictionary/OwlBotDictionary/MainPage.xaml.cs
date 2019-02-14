using System;
using Xamarin.Forms;
using Plugin.Connectivity;

namespace OwlBotDictionary
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SearchButton_Clicked(object sender, EventArgs e)
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                await DisplayAlert("ERROR", "Internet Connection Required.", "OK");
                return;
            }

            if (String.IsNullOrEmpty(WordBox.Text))
            {
                await DisplayAlert("ERROR", "Please Enter a word before searching.", "OK");
                return;
            }
            else
            {
                await Navigation.PushAsync(new WordPage(WordBox.Text.ToLower()));
            }
        }

        private void MainPage_Appearing(object sender, EventArgs e)
        {
            WordBox.Text = String.Empty;
        }
    }
}
