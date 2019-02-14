using System;
using Xamarin.Forms;

namespace BCole_NavigationApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Handle_NavigateToSecondPage(object sender, EventArgs e)
        {
            var name = NameTextEntry.Text;

            await Navigation.PushAsync(new SecondPage(name));
        }

        private void Handle_Appearing(object sender, EventArgs e)
        {
            NameTextEntry.Text = String.Empty;
        }
    }
}
