using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBallMatching.Models {
    public class LoginModel : ObservableObject {
        private int _userID;
        private string _username;
        private string _password;

        public int Userid {
            get { return _userID; }
            set { _userID = value; OnPropertyChanged("_userID"); }
        }

        public string Username {
            get { return _username; }
            set { _username = value; OnPropertyChanged("_username"); }
        }

        public string Password {
            get { return _password; }
            set { _password = value; OnPropertyChanged("_password"); }
        }
    }
}
