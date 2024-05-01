using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using MVVMLight;
namespace MVVMLight.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            Messenger.Default.Register<NotificationMessage>(this, NotifyUserMethod);
            SimpleIoc.Default.Register<WinCommunication1ViewModel>();
            SimpleIoc.Default.Register<WinCommunication2ViewModel>();
        }

        private void NotifyUserMethod(NotificationMessage obj)
        {
            MessageBox.Show(obj.Notification);
        }
        public WinCommunication1ViewModel winCommunication1ViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<WinCommunication1ViewModel>();
            }
        }
        public WinCommunication2ViewModel winCommunication2ViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<WinCommunication2ViewModel>();
            }
        }
        public MainViewModel MainViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainViewModel>();
            }
        }
    }
}
