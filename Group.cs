using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WpfApp_lab4
{
    [XmlType("Group")]
    [XmlInclude(typeof(Section)), XmlInclude(typeof(Teacher)), XmlInclude(typeof(Group)), XmlInclude(typeof(HouseOfCreativity))]
    [Serializable]
    public class Group
    {
        private string Name { get; set; }
        [XmlElement("NameCopy")]
        public string NameCopy { get; set; }

        private Section section { get; set; }

        private Teacher teacher { get; set; }
        [XmlElement("teacher")]
        public Teacher teacherCopy { get; set; }

        private int pay { get; set; }
        [XmlElement("payCopy")]
        public int payCopy { get; set; }

        private int NumberOfLessons { get; set; }
        [XmlElement("NumberOfLessonsCopy")]
        public int NumberOfLessonsCopy { get; set; }

        private int NumberOfStudents { get; set; }
        [XmlElement("NumberOfStudentsCopy")]
        public int NumberOfStudentsCopy { get; set; }

        public override String ToString()
        {
            return "Плата грн/міс: " + payCopy + "; Кілкість занять: " + NumberOfLessonsCopy + "; Кілкість студентів: " + NumberOfStudentsCopy; 
        }

        public Group(string name, Teacher teacher, int pay, int numberOfLessons, int numberOfStudents)
        {
            this.Name = name;
            NameCopy = name;
            this.teacher = teacher;
            teacherCopy = teacher;
            this.pay = pay;
            payCopy = pay;
            this.NumberOfLessons = numberOfLessons;
            NumberOfLessonsCopy = numberOfLessons;
            this.NumberOfStudents = numberOfStudents;
            NumberOfStudentsCopy = numberOfStudents;
        }

        public Group() { }
    }
}
