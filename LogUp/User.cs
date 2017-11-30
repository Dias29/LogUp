using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LogUp
{
    class User
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phonenumber;
        private string _password;

        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        bool IsEmail(string email)
        {
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@')
                    return true;
            }
            return true;
        }

        public void SetEmail(string email)
        {
            
            for(int i=0; i<email.Length; i++)
            {
                IsEmail(email);
            }
            _email = email;

        }

        public string GetEmail()
        {
            return _email;
        }

        public void SetNumber(string number)
        {
            bool isStarts = number.StartsWith("+");
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for(int i =0; ;)
            _phonenumber = number;
        }

        public string GetNumber()
        {
            return _phonenumber;
        }

        public void SetPassword(string password)
        {
           for (int i=0; i<password.Length; i++)
            {
                //password = ReadLine();
                string lengthOfPassword = "12345678";
                if (password.Length < lengthOfPassword.Length)
                {
                    WriteLine("Пароль должен быть больше 8 символов!");
                }
            }

            _password = password;
        }

        public string GetPassword()
        {
            return _password;
        }

        


    }
}
