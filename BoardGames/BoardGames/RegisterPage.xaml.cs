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
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			InitializeComponent ();
		}

        //sitas metodas pasileidzia kai paspaudi register mygtuka, reikia ivest nauja vartotoja i duombaze
        void Handle_Clicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;                 //gaunam ivestus duomenis po mygtuko paspaudimo
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;
            string conPassword = confirmPasswordEntry.Text;

            Navigation.PopAsync(); //gryzta i ankstesni langa (UserLogin)
        }
	}
}