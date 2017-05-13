using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingOneWay
{
    public class Employee : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        private DateTime _startDate;

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public static Employee GetEmployee()
        {
            var emp = new Employee
            {
                Name = "Tom",
                Title = "Developer"
            };
            return emp;
        }

        public static ObservableCollection<Employee> GetEmployees()
        {
            var list = new ObservableCollection<Employee>
            {
                new Employee() { Name = "Maria", Title = "President 1" },
                new Employee() { Name = "Joe", Title = "President 2" },
                new Employee() { Name = "Max", Title = "President 3" },
                new Employee() { Name = "Eduard", Title = "President 4" },
                new Employee() { Name = "Steven", Title = "President 5" }
            };
            return list;
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
