using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BoardGames
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void Handle_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GameSessionsPage());
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
