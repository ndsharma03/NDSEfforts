using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMTests.Model;

namespace MVVMTests.ViewModel
{
    class CustomerViewModel: ViewModelBase
    {
        Customer _customer;
        public CustomerViewModel()
        {
            _customer = new Customer { CustomerId = 1, CustomerName = "Nds" };
            
        }
        

        public RelayCommand AddButtonCommand
        {
            get
            {
                return new RelayCommand(AddButtonClick);
            }
        }

        private void AddButtonClick(object obj)
        {
            System.Windows.MessageBox.Show(_customer.CustomerName);
        }

        public int CustomerId {
            get
            {
                return _customer.CustomerId;
            }
            set
            {
                _customer.CustomerId = value;
                OnPropertyChanged(nameof(CustomerId));
          
            }
        }
        public string CustomerName
        {
            get
            {
                return _customer.CustomerName;
            }
            set
            {
                _customer.CustomerName = value;
                OnPropertyChanged(nameof(CustomerName));

            }
        }
    }
}
