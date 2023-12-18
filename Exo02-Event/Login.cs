using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Exo02_Event
{
    internal class Login
    {
        private string Email;
        private string Password;

        public event EventHandler LoginOkEvent = null;
        public event EventHandler LoginNotOkEvent = null;

        public string Login(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public void CheckLogin(string email, string password)
        {
            if (Email == email && Password == password) 
            {
                LoginOkEvent?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                LoginNotOkEvent?.Invoke(this, EventArgs.Empty);
            }
        }
    }

}
