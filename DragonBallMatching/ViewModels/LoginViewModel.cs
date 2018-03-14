using DragonBallMatching.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBallMatching.ViewModels
{
    public class LoginViewModel
    {

        public LoginClass LoginClass;

        public LoginViewModel()
        {
            LoginClass = new LoginClass();
            
        }
    }
}
