using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuickReview.ViewModel
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action<object> _Execute;
        Predicate<object> _CanExecute;
        public RelayCommand(Action<object> execute,Predicate<object> canExecute)
        {
            _CanExecute = canExecute;
            if (execute == null) throw new Exception(" Please provide execute method");
            _Execute = execute;
        }
        public RelayCommand(Action<object> execute)
        {
           _Execute = execute;
        }
        public bool CanExecute(object parameter)
        {
            if (_CanExecute != null)
                return _CanExecute(parameter);
            return true;
        }

        public void Execute(object parameter)
        {
            _Execute(parameter);
        }
    }
}
