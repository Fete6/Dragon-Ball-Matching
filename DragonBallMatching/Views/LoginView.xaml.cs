using DragonBallMatching.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DragonBallMatching.Views {
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl, IHavePassword {
        public LoginView() {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }

        // Required for password to be processed.
        public System.Security.SecureString Password {
            get {
                return passwordBox.SecurePassword;
            }
        }
    }
}
