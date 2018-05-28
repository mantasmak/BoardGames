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
	public partial class GameSessionsPage : ContentPage
	{
		public GameSessionsPage ()
		{
            MessagingCenter.Subscribe<GameCreationPage>(this, "Hi", (sender) => { });

            InitializeComponent ();

            listView.ItemsSource = GetGames();
		}

        private List<Game> GetGames(string searchText = null)
        {
            var games = new List<Game>
            {
                new Game("My Game", "Chess", 2, 2, "Vilnius, Ilgoji g. 5", new DateTime(2018, 5, 30, 18, 30, 0)),
                new Game("Another Game", "Monopoly", 2, 5, "Vilnius, Gedimino pr. 5", new DateTime(2018, 5, 31, 9, 0, 0)),
                new Game("Birthday Party", "Scrabble", 2, 4, "Kaunas, Nemuno g. 22", new DateTime(2018, 6, 22, 20, 0, 0)),
                new Game("Join my game", "D&D", 3, 5, "Klaipėda, Pilies g. 3", new DateTime(2018, 6, 5, 17, 25, 0))
            };

            if (String.IsNullOrWhiteSpace(searchText))
                return games;

            return games.Where(g => g.RoomName.ToUpper().StartsWith(searchText.ToUpper()) ||
                                    g.GameName.ToUpper().StartsWith(searchText.ToUpper()) ||
                                    g.Location.ToUpper().StartsWith(searchText.ToUpper())).ToList();
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var game = e.Item as Game;
            Navigation.PushAsync(new GameDetailsPage(game));
        }

        void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetGames(e.NewTextValue);
        }

        async void Handle_Activated(object sender, EventArgs e)
        {
            var gameCreationPage = new GameCreationPage();
            await Navigation.PushAsync(gameCreationPage);
        }
    }
}