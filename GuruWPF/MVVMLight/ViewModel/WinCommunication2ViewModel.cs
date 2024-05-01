using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
namespace MVVMLight.ViewModel
{
    public class WinCommunication2ViewModel:ViewModelBase
    {
        public WinCommunication2ViewModel()
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
