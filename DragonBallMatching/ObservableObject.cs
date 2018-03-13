using System.ComponentModel;
using System.Runtime.CompilerServices;

/// <summary>
/// Observable objects will derive from this.
/// </summary>
namespace DragonBallMatching {
    public class ObservableObject : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        // CallerMemberName allow "propertychanged" to be raised without a parameter.
        protected void OnPropertyChanged([CallerMemberName]string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
