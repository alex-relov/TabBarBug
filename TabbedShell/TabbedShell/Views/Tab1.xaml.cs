using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedShell.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tab1 : ContentPage
    {
        public Tab1()
        {
            InitializeComponent();
        }

        private async void Page1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}