using System;
using System.Windows.Input;

namespace DragonBallMatching {
    public class RelayCommand : ICommand {

        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;


        public RelayCommand(Action<object> execute, Predicate<object> canExecute) {
            // This check if execute is null and either sets the value (if not null) or throw exeception!
            _execute = execute ?? throw new NullReferenceException("Execute Exception!");
            _canExecute = canExecute;
        }

        public RelayCommand(Action<object> execute) : this(execute, null) {

        }

        // RequerySuggested will pick up on changes that could affect the outcome of "canexecute",
        // e.g. such as a bound text box losing focus will invoke a check, even when its not needed.
        // This does not work when using threaded async operations!
        public event EventHandler CanExecuteChanged {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter) {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter) {
            _execute.Invoke(parameter);
        }
    }
}
