using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QuickReview.Model;
using QuickReview.View;

namespace QuickReview.ViewModel
{
    
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
    public class StudentViewModel:ViewModelBase
    {
        public ObservableCollection<Student> Students { get; set; }
        
        private string _studentName;
        private int _studentAge;
        RelayCommand _addCommand;
        BackgroundWorker bgWorker = new BackgroundWorker();
        public StudentViewModel()
        {
            Students = new ObservableCollection<Student>();
            _addCommand = new RelayCommand(AddStudent);
            ViewStudentCmd = new RelayCommand(ViewSelectedStudent);
            Thread.CurrentThread.SetApartmentState(ApartmentState.STA);
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(9000);
            //SelectedStudent viewSelectedStudent = new SelectedStudent();
            //viewSelectedStudent.DataContext = SelectedStudent;
            //viewSelectedStudent.Show();
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(9000);

            
        }

        public  void AddStudent(object param)
        {
            
                Students.Add(new Student { Name = StudentName, Age = StudentAge });
                   
            
        }
  
        public async void ViewSelectedStudent(object param)
        {

            await Task.Delay(5000);
            //bgWorker.RunWorkerAsync();
            SelectedStudent viewSelectedStudent = new SelectedStudent();
            viewSelectedStudent.DataContext = SelectedStudent;
            viewSelectedStudent.Show();
        }
        public Student SelectedStudent
        {
            get;set;
        }
        public RelayCommand AddStudentCmd
        {
            get { return _addCommand; }
            
        }
        public RelayCommand ViewStudentCmd
        {
            get;

        }
        public string StudentName {
            get
            {
                return _studentName;
            }
            set
            {
                _studentName = value;
                OnPropertyChanged(nameof(StudentName));
            }
        }
        public int StudentAge {
            get
            {
                return _studentAge;
            }
            set
            {
                _studentAge = value;
                OnPropertyChanged(nameof(StudentAge));
            }
        }
    }
}
