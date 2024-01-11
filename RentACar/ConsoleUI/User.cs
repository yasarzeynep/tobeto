﻿namespace ConsoleUI
{
    internal class User : Entity //Tekli Miras
    {
        //internal int Id { get; set; }
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string Nickname { get; set; }
        internal string Email { get; set; }
        private string _password;
        internal string Password {
            //get { return _password;  }
            set { _password = hashPassword(value); }
        }

      internal User(int id, string firstName, string lastName, string nickName, string email, string password) :base(id) // Kurucu Metot // Constructor
        {
       
            FirstName = firstName;
            LastName = lastName;
            Nickname = nickName;
            Email = email;
            Password = password;
            
            Console.WriteLine("Bir User Olustu");
        }

        private string hashPassword(string passwordToHash)
        {
            return passwordToHash + "HASH136.@@!#A#S@";
        }

    }
}

