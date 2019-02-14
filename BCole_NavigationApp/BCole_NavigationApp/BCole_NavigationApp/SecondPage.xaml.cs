
using Xamarin.Forms;

namespace BCole_NavigationApp
{
    public partial class SecondPage : ContentPage
	{
		public SecondPage ()
		{
			InitializeComponent ();
		}

        public SecondPage(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "Generic Human";
            }

            InitializeComponent();
            NameLabel.Text = $"Welcome, {name}!";
        }

        private async void Handle_NavigateToMainPage(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}