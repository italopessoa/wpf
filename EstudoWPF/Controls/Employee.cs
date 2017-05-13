using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Controls
{
    public class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;

        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _wasReelected;

        public bool WasReelected
        {
            get { return _wasReelected; }
            set { SetProperty(ref _wasReelected, value); }
        }

        private Party _affiliation;

        public Party Affiliation
        {
            get { return _affiliation; }
            set { SetProperty(ref _affiliation, value); }
        }


        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee { Name = "Washington", Title = "President 1", WasReelected = true, Affiliation = Party.Federalist });
            employees.Add(new Employee { Name = "Washington", Title = "President 2", WasReelected = true, Affiliation = Party.DemocratRepuclican });
            employees.Add(new Employee { Name = "Washington", Title = "President 3", WasReelected = false, Affiliation = Party.Independent });
            employees.Add(new Employee { Name = "Washington", Title = "President 4", WasReelected = true, Affiliation = Party.DemocratRepuclican });
            employees.Add(new Employee { Name = "Washington", Title = "President 5", WasReelected = false, Affiliation = Party.Federalist });
            return employees;
        }

        private bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public enum Party
    {
        Independent,
        Federalist,
        DemocratRepuclican
    }
}
