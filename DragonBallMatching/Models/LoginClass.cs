using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBallMatching.Models
{
    public class LoginClass : ObservableObject
    {
        private int _userid;
        private string _username;
        private string _pwd;

        //public LogonClass(int Userid, string Username, string Pwd)
        //{
        //    this.Userid = Userid;
        //    this.Username = Username;
        //    this.Pwd = Pwd;
        //}

        public string Pwd
        {
            get { return _pwd; }
            set { _pwd = value; OnPropertyChanged("Pwd"); }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; OnPropertyChanged("Username"); }
        }

        public int Userid
        {
            get { return _userid; }
            set { _userid = value; OnPropertyChanged("Userid"); }
        }

    }
}
