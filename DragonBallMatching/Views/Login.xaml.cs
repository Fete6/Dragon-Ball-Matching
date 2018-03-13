using DragonBallMatching.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
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

namespace DragonBallMatching.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }
        UserClass User = new UserClass("Frederik", "Christensen",DateTime.Today, );

        private void Btn_CreateAccount_Click(object sender, RoutedEventArgs e) {
            NewAccount_01 newAccount_01 = new NewAccount_01();
            NavigationService.Navigate(newAccount_01); 
        }
    }
}
