using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class StudentModel : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get => firstName;
            set
            {
                if(firstName!=value)
                {
                    firstName = value;
                    RisePropertyEvent("FirstName");
                    RisePropertyEvent("FullName");
                }
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if(lastName!=value)
                {
                    lastName = value;
                    RisePropertyEvent("LastName");
                    RisePropertyEvent("FullName");
                }
            }
        }

        public string FullName { get => firstName+ " "+lastName; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RisePropertyEvent(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
