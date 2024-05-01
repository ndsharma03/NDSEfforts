using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTests.ViewModel
{
    class CanExecuteChangeEventDemoViewModel : ViewModelBase
    {
        private int button_click_counter=0;
        private CanExcuteChnageDemoCommand _buttonClick =null;
        public CanExecuteChangeEventDemoViewModel()
        {
            Button_Click_Counter = 0;
            _buttonClick= new CanExcuteChnageDemoCommand(Button_Click_Execute, Button_Click_CanExecute);
        }
        public int Button_Click_Counter {
            get
            {
                return button_click_counter;
            }
            set{
                    button_click_counter = value;
                    OnPropertyChanged(nameof(Button_Click_Counter));
               
                }
            }

        public CanExcuteChnageDemoCommand ButtonClickCmd
        {
            get {
                return _buttonClick;
            }
        }
        private void Button_Click_Execute(object obj)
        {
            Button_Click_Counter++;
        }
       private  bool Button_Click_CanExecute(object obj)
        {
            if (Button_Click_Counter > 1)
                return false;
            return true;
        }
       
    }
}
