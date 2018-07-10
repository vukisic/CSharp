using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Project
{
    public class Course
    {
        private string name;
        private int ects;
        private int grade;
        private bool passed;

        public Course()
        {
            this.Name = "";
            this.Ects = 0;
            this.Grade = 0;
            this.Passed = false;
        }

        public string Name { get => name; set => name = value; }
        public int Ects { get => ects; set => ects = value; }
        public int Grade { get => grade; set => grade = value; }
        public bool Passed { get => passed; set => passed = value; }
    }
}
