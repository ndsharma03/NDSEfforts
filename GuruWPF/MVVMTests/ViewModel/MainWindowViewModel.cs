using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTests.ViewModel
{
    class MainWindowViewModel:ViewModelBase
    {
        public MainWindowViewModel()
        {

        }
        public RelayCommand CustomerMenu
        {
            get
            {
                return new RelayCommand(CustomerMenuClick);
            }
        }
        private object _content;
        public object PaceholderContent
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
                OnPropertyChanged("PaceholderContent");

            }
        }
        public void CustomerMenuClick(object param)
        {
            CustomerViewModel _customer = new CustomerViewModel();
            PaceholderContent = _customer;
        }
    }
}
