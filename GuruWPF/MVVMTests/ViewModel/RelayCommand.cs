using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMTests.ViewModel
{
   public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<object> _execute;
        private Func<object, bool> _canExecute;
        
            
        
        public RelayCommand(Action<object> execute):this(execute,null)
        {
            _execute = execute;
            
        }
        public  RelayCommand (Action<object> execute, Func<object, bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            if(_canExecute!=null)
            {
                return _canExecute( parameter);
            }
            return true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public virtual void OnCanExecuteChange()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, new EventArgs());
            }
        }
    }
}
