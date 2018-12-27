using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfApp1
{
    public class Person: INotifyPropertyChanged
    {
        public ICommand IncrementAge { get; set; }

        public Person()
        {
            IncrementAge = new IncrementAgeCommand(this);
        }

        private string firstNameVal;
        public string FirstName
        {
            get { return firstNameVal; }
            set
            {
                firstNameVal = value;
                NotifyPropertyChanged("FirstName");
            }
        }

        private string lastNameVal;
        public string LastName
        {
            get { return lastNameVal; }
            set
            {
                lastNameVal = value;
                NotifyPropertyChanged("LastName");
            }
        }

        private int ageVal;
        public int Age
        {
            get { return ageVal; }
            set
            {
                ageVal = value;
                NotifyPropertyChanged("Age");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
