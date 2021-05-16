using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp_lab4
{
    public class Group
    {
        private string Name { get; set; }

        private Section section { get; set; }

        private Teacher teacher { get; set; }

        private int pay { get; set; }

        private int NumberOfLessons { get; set; }

        private int NumberOfStudents { get; set; }

        public Group(string name, Section sectionType, Teacher teacher, int pay, int numberOfLessons, int numberOfStudents)
        {
            this.Name = name;
            this.section = sectionType;
            this.teacher = teacher;
            this.pay = pay;
            this.NumberOfLessons = numberOfLessons;
            this.NumberOfStudents = numberOfStudents;
        }
    }
}
