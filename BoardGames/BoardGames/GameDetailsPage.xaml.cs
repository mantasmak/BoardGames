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
	public partial class GameDetailsPage : ContentPage
	{
        Game selectedGame;

		public GameDetailsPage (Game game)
		{
            if (game == null)
                throw new ArgumentNullException();

            BindingContext = game;

            selectedGame = game;

			InitializeComponent ();
		}

        void Handle_Clicked(object sender, EventArgs e)
        {
            if (selectedGame.MaxPlayers > selectedGame.PlayerCount)
            {
                selectedGame.PlayerCount++;
                Navigation.PopAsync();
                return;
            }

            DisplayAlert("Error", "Maximum amount of players reached", "Cancel");
        }
	}
}