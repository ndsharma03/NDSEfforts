using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMLight.ViewModel;
using GalaSoft.MvvmLight;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace MVVMLight.ViewModel
{
    public class WinCommunication1ViewModel:ViewModelBase
    {

        WinCommunication2ViewModel win2ViewModel;
        public WinCommunication1ViewModel()
        {

            
        }


        public RelayCommand<object> SendCommand
        {
            get
            {
               return new RelayCommand<object>(ExecuteSend, CanExecuteSend);
            }
        }
        public void ExecuteSend(object param)
        {
            
        }
        public bool CanExecuteSend(object param)
        {
            return true;
        }
    }
}
