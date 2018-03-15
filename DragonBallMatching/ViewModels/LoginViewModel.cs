using DragonBallMatching.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DragonBallMatching.ViewModels
{
    public class LoginViewModel
    {

        public LoginClass LoginClass;

        public Dragon_Ball_MatchingEntities db;

        public LoginViewModel()
        {
            LoginClass = new LoginClass();
            db = new Dragon_Ball_MatchingEntities();
        }

        
        public bool CheckUsername(string user)
        {

            LogonTable logontable = new LogonTable();
            logontable = db.LogonTable.FirstOrDefault(p => p.Username == user);
            if (logontable == null ) { return false; }
            //MessageBox.Show(logontable.Username.ToString());
            return true;
        }
    }
}
