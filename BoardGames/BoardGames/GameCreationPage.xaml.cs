using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BoardGames
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GameCreationPage : ContentPage
	{
        Game newGame = null;

		public GameCreationPage ()
		{
			InitializeComponent ();
		}

        void Handle_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(roomName.Text) || String.IsNullOrWhiteSpace(gameName.Text) || String.IsNullOrWhiteSpace(minPlayer.Text) || String.IsNullOrWhiteSpace(maxPlayer.Text) || String.IsNullOrWhiteSpace(location.Text))
            {
                DisplayAlert("Error", "Some data is missing.", "Cancel");
                return;
            }

            newGame = new Game(roomName.Text, gameName.Text, Int32.Parse(minPlayer.Text), Int32.Parse(maxPlayer.Text), location.Text, datePicker.Date + timePicker.Time);

            Navigation.PopAsync();
        }
	}
}