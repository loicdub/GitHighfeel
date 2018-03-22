using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highfeel
{
    class User
    {
        private int _userId;
        private string _userName;

        public int UserId { get => _userId; set => _userId = value; }
        public string UserName { get => _userName; set => _userName = value; }

        public User() { }

        public User(int userId)
        {
            this.UserId = userId;
        }

        public User(string userName)
        {
            this.UserName = UserName;
        }

        public User(int userId, string userName)
        {
            this.UserId = userId;
            this.UserName = UserName;
        }
    }
}
