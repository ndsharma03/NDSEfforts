using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMTests.ViewModel;
namespace MVVMTests
{
    class CanExcuteChnageDemoCommand :RelayCommand
    {

        ViewModelBase _viewModel;
        public CanExcuteChnageDemoCommand(Action<object> execute, Func<object, bool> canExecute,ViewModelBase viewModel) : base(execute, canExecute)
        {
            _viewModel = viewModel;
            _viewModel.PropertyChanged += _viewModel_PropertyChanged;
        }

        private void _viewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Contains("Counter")){
                OnCanExecuteChange();//raising can eceute change so control will call CanExecute and will decide to fire command or not.
            }
        }

        public CanExcuteChnageDemoCommand(Action<object> execute,Func<object,bool> canExecute) : base(execute, canExecute)
        {

        }
        public CanExcuteChnageDemoCommand(Action<object> execute) : base(execute)
        {

        }
    }
}
