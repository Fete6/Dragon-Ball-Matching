using DragonBallMatching.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DragonBallMatching.ViewModels {
    public class LoginViewModel : BaseViewModel {
        // Fields.
        private LoginModel _loginModel;
        private Dragon_Ball_MatchingEntities _db;

        // Properties.
        public LoginModel LoginModel {
            get { return _loginModel; }
            set { _loginModel = value; }
        }

        public Dragon_Ball_MatchingEntities Db {
            get { return _db; }
            set { _db = value; }
        }

        // RelayCommands for buttons.
        public RelayCommand SignInCommand { get; private set; }
        public RelayCommand CreateAccountCommand { get; private set; }

        // Contructor.
        public LoginViewModel() {
            LoginModel = new LoginModel();
            SignInCommand = new RelayCommand(SignIn, SignInCanUse);
            CreateAccountCommand = new RelayCommand(CreateAccount);

            Db = new Dragon_Ball_MatchingEntities();
        }

        public void SignIn(object parameter) {
            LogonTable logonTable = new LogonTable();

            // Convert Secure string to SHA to match against database.
            string SecureStringToSHA = PasswordEncrypt(parameter);

            // Checks against username and SHA.
            logonTable = Db.LogonTables.FirstOrDefault(p => p.Username == LoginModel.Username && p.PWD == SecureStringToSHA);

            if (logonTable == null) { MessageBox.Show("Incorrect!"); return; }

            MainWindowViewModel.MainVM.CurrentView = new SearchViewModel();
        }

        public void CreateAccount(object parameter) {
            MainWindowViewModel.MainVM.CurrentView = new CreateAccountViewModel();
        }

        public bool SignInCanUse(object parameter) {
            // Check against password or username being empty.
            var passwordContainer = parameter as IHavePassword;
            if (passwordContainer == null) { return false; }

            var secureString = passwordContainer.Password;
            if (string.IsNullOrWhiteSpace(LoginModel.Username) || secureString.Length == 0) { return false; }
            return true;
        }


        /////////////// Password related functions /////////////////

        private string PasswordEncrypt(object parameter) {
            var passwordContainer = parameter as IHavePassword;
            if (passwordContainer != null) {
                StringBuilder Sb = new StringBuilder();
                var secureString = passwordContainer.Password;

                using (SHA256 hash = SHA256Managed.Create()) {
                    Encoding enc = Encoding.UTF8;
                    // TODO - Could change salt to ID rather than Username.
                    string input = ConvertToUnsecureString(secureString) + LoginModel.Username;
                    Byte[] result = hash.ComputeHash(enc.GetBytes(input));

                    foreach (Byte b in result)
                        Sb.Append(b.ToString("x2"));
                    //MessageBox.Show(Sb.ToString()); // Testing string
                }
                return Sb.ToString();
            }
            return "";
        }

        private string ConvertToUnsecureString(System.Security.SecureString securePassword) {
            if (securePassword == null) {
                return string.Empty;
            }

            IntPtr unmanagedString = IntPtr.Zero;
            try {
                unmanagedString = System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                return System.Runtime.InteropServices.Marshal.PtrToStringUni(unmanagedString);
            } finally {
                System.Runtime.InteropServices.Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

    }
}
