using DragonBallMatching.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DragonBallMatching.ViewModels {
    public class MainWindowViewModel : BaseViewModel {

        // Fields.
        public static MainWindowViewModel MainVM;

        private ObservableCollection<string> _menuItems;
        private string _menuItemSelected;
        private BaseViewModel _currentView;
        private int _userID; // Assigned when sigend in.

        public int UserID {
            get { return _userID; }
            set { _userID = value; }
        }

        // Properties.
        public ObservableCollection<string> MenuItems {
            get { return _menuItems; }
            set { _menuItems = value; }
        }

        public string MenuItemSelected {
            get { return _menuItemSelected; }
            set { _menuItemSelected = value;
                OnPropertyChanged("MenuItemSelected");
                ChangeCurrentView(MenuItemSelected);
            }
        }

        /// <summary>
        /// Holds the current view. 
        /// </summary>
        public BaseViewModel CurrentView {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged("CurrentView"); }
        }

        // Contructor.
        public MainWindowViewModel() {
            MainVM = this;

            // Menu Items set.
            MenuItems = new ObservableCollection<string>() { "Login", "Search" };
            // Initialize with default (login) view in usercontrol.
            CurrentView = new LoginViewModel();
        }

        /// <summary>
        /// Get called from the "MenuItemSelected" property when value is changed. 
        /// </summary>
        /// <param name="selectedView"></param>
        public void ChangeCurrentView(string selectedView) {
            switch (selectedView) {
                case "Login":
                    CurrentView = new LoginViewModel();
                    break;
                case "Search":
                    CurrentView = new SearchViewModel();
                    break;
                default:
                    break;
            }
        }

    }
}
