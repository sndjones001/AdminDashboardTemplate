using System;
using System.Windows.Input;

namespace QuSwense.ModernControls.ViewModel
{
    public class RelayCommand : ICommand
    {
        private Action _execute;

        public RelayCommand(Action execute)
        {
            _execute = execute;
        }

        public event EventHandler? CanExecuteChanged = (sender, e) => { };

        public bool CanExecute(object? parameter) => _execute != null;

        public void Execute(object? parameter) => _execute();
    }
}
