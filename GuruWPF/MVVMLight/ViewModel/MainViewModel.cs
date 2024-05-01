using GalaSoft.MvvmLight;
using MVVMLight.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace MVVMLight.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Employee> employees=new ObservableCollection<Employee>();
        private Employee _selectedEmployee;
        public ICommand SaveEmployeesCommand { get; private set; }
        public ICommand LoadEmployeesCommand { get; private set; }
        public ObservableCollection<Employee> Employees
        {
            get => employees;
            set
            {
                employees = value;
                RaisePropertyChanged(nameof(Employee));
            }
            //set => employees = value;
        }
        public Employee SelectedEmployee
        {
            get {
                    return _selectedEmployee;
                }
            set {
                     _selectedEmployee = value;
                    RaisePropertyChanged(nameof(SelectedEmployee));
               }
        }

        public MainViewModel()
        {
            SaveEmployeesCommand = new RelayCommand(new System.Action(SaveEmployees));
            LoadEmployeesCommand = new RelayCommand(new System.Action(LoadEmployees));
        }

         void SaveEmployees()
        {
            Messenger.Default.Send<NotificationMessage>(new NotificationMessage("Employee Saved Successfully"));

        }
        void LoadEmployees()
        {
            Employees = Employee.GetSampleEmployees();
            Messenger.Default.Send<NotificationMessage>(new NotificationMessage("Employee Loaded Successfully!!"));
        }
    }
}