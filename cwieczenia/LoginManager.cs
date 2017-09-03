using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwieczenia
{
    class LoginManager
    {
        private string login;
        private string password;
        public LoginManager()
        {
            login = "kamil";
            password = "pawlak";

        }
        public LoginManager(string user, string pass)
        {
            this.login = user;
            this.password = pass;

        }


        public void Logowanie()
        {
            Console.WriteLine("Podaj login:");
            string tryLogin = Console.ReadLine();
            Console.WriteLine("Podaj haslo:");
            string tryPass = Console.ReadLine();
            
        }
    }
}
