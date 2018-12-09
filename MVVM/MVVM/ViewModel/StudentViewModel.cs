using MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModel
{
    public class StudentViewModel
    {
        public ObservableCollection<StudentModel> Students { get; set; }

        public StudentViewModel()
        {
            Load();
        }

        public void Load()
        {
            ObservableCollection<StudentModel> tempStudent = new ObservableCollection<StudentModel>()
            {
                new StudentModel{FirstName="Vuk",LastName="Isic"},
                new StudentModel{FirstName="Pera",LastName="Petrovic"},
                new StudentModel{FirstName="Marko",LastName="Markovic"}
            };

            Students = tempStudent;
        }
    }
}
