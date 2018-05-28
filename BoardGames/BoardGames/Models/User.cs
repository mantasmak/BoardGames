using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGames.Models
{
    public class User
    {
        public static int Id = 0;
        public string Name { get; set; }
        public string Password { get; set; }

        public User(string name, string password)
        {
            Id++;
            Name = name;
            Password = password;
        }
    }
}
