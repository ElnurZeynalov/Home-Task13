using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class User
    {
        private int _id;
        private string _password;
        public int Id { get=>_id;}
        public string Username { get; set; }
        public string Password { get=>_password;
            set
            {
                if(value.PasswordChecker())
                _password = value;
            }
                }
        public Role Role { get; set; }
        public User(string username , string password , Role role)
        {
            _id++;
            Username = username;
            Password = password;
            Role = role;
        }
        public string ShowInfo()
        {
            return $"Id: {this.Id} Username: {this.Username} - Password: {this.Password} Role: {this.Role}";
        }
    }
}
