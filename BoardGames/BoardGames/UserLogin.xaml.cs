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
	public partial class UserLogin : ContentPage
	{
		public UserLogin ()
		{
			InitializeComponent ();
		}

        //login mygtuko paspaudimas, reikia patikrinti ar toks vartotojas yra duombazeje
        async void Handle_LoginClicked(object sender, EventArgs e)
        {
            string emailUsername = emailUsernameEntry.Text; //gaunam ivestus duomenis po mygtuko paspaudimo
            string password = passwordEntry.Text;

            await Navigation.PushAsync(new GameSessionsPage());     //pereinam i zaidimu sarasa
        }

        async void Handle_RegisterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
	}
}