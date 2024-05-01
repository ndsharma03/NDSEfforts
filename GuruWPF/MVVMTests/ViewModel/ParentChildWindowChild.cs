using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTests.ViewModel
{
    public delegate string PassMessage(string message);

    class ParentChildWindowChild : ViewModelBase
    {
        RelayCommand _sendMessageToParentCommand;
        public PassMessage passMessageToParentWindow ;
        //public PassMessage PassMessage
        //{
        //    set
        //    {
        //        passMessageToParentWindow = value;
        //    }
        //    get
        //    {
        //        return passMessageToParentWindow;
        //    }
        //}

        public ParentChildWindowChild()
        {
            SendMessageToParentCommand = new RelayCommand(ExecuteSendMessageToParentCommand);
            //passMessageToParentWindow = new PassMessage((s)=> { return s; });
            IsNeedToOpeninNewWindow = false;
        }

        #region To GetFocus on this Window
        bool _setFoucs;
        public bool SetFocus
        {
            get { return _setFoucs; }
            set { _setFoucs = value; OnPropertyChanged(nameof(SetFocus)); }
        }
        #endregion

        public RelayCommand SendMessageToParentCommand
        {
            get => _sendMessageToParentCommand;
            set => _sendMessageToParentCommand = value;
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
        public void ExecuteSendMessageToParentCommand(object val)
        {
            if(passMessageToParentWindow!=null)
            passMessageToParentWindow(TextMessage);
           // SetFocus = false;
        }
    }
}
