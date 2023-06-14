using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StopWatch_WPF.Commands
{
    public class RelayCommand : ICommand
    {
        private readonly Action _command;

        public RelayCommand(Action command)
        {
            this._command = command;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return _command != null;
        }

        public void Execute(object? parameter)
        {
            _command.Invoke();
        }
    }
}
