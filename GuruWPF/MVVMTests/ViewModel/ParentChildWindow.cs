using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTests.ViewModel
{
    class ParentChildWindow: ViewModelBase
    {

        #region To GetFocus on this Window
        bool _setFoucs;
        public bool SetFocus {
            get { return _setFoucs; }
            set { _setFoucs = value; OnPropertyChanged(nameof(SetFocus)); }
        }
        #endregion
        RelayCommand _OpenChildCommand;
       public ParentChildWindow()
        {
            _OpenChildCommand = new RelayCommand(ExecuteOpenChildCommand);
        }

        public RelayCommand OpenChildCommand
        {
            get
            {
                return _OpenChildCommand;
            }

        }
        private string _txtMessage;
        public string TextMessage
        {
            get
            {
                return _txtMessage;
            }
            set
            {
                _txtMessage = value;
                OnPropertyChanged(nameof(TextMessage));
            }


        }
        ParentChildWindowChild vmChild;
        public void ExecuteOpenChildCommand(object val)
        {
           
            if (vmChild == null)
                vmChild = new ParentChildWindowChild();
            

            if(vmChild.passMessageToParentWindow==null) // if not already subscribed
                 vmChild.passMessageToParentWindow += callbackMessage;
         
            vmChild.TextMessage += TextMessage;
            if (vmChild.IsNeedToOpeninNewWindow || !vmChild.IsOpenedInWindow) // open VM in new windows if it's not already open 
                                                                              //OR when explicitly need to open in new Viewmodel.
            { 
                IWindowService service = new WindowService();
                service.OpenWindow(vmChild);
                
            }
          //  SetFocus = false;
            vmChild.SetFocus = true;//Setting focus on child window via attached property.
        }
        public string callbackMessage(string message)
        {
            TextMessage += "Child :" + message;
            SetFocus = true;
            return "Parent :" + message;

        }
    }
}
