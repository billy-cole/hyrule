using System;
using Xamarin.Forms;

namespace BCole_Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NumberText.Text = String.Empty;
        }

        private void SevenButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text += SevenButton.Text;
        }

        private void EightButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text += EightButton.Text;
        }

        private void NineButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text += NineButton.Text;
        }

        private void DivideButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text += DivideButton.Text;
        }

        private void FourButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text += FourButton.Text;
        }

        private void FiveButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text += FiveButton.Text;
        }

        private void SixButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text += SixButton.Text;
        }

        private void MultiplyButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text += MultiplyButton.Text;
        }

        private void OneButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text += OneButton.Text;
        }

        private void TwoButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text += TwoButton.Text;
        }

        private void ThreeButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text += ThreeButton.Text;
        }

        private void MinusButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text += MinusButton.Text;
        }

        private void ZeroButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text += ZeroButton.Text;
        }

        private void PlusButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text += PlusButton.Text;
        }

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text = String.Empty;
        }

        private void EqualButton_Clicked(object sender, EventArgs e)
        {
            NumberText.Text += EqualButton.Text;
        }


    }
}
