using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WpfApp_lab4
{
    [XmlType("Teacher")]
    [XmlInclude(typeof(Section)), XmlInclude(typeof(Teacher)), XmlInclude(typeof(Group)), XmlInclude(typeof(HouseOfCreativity))]
    [Serializable]

    public class Teacher
    {
        private string FirstName { get; set; }
        [XmlElement("FirstNameCopy")]
        public string FirstNameCopy { get; set; }

        private string LastName { get; set; }
        [XmlElement("LastNameCopy")]
        public string LastNameCopy { get; set; }

        private DateTime DateOfBirth { get; set; }
        [XmlElement("DateOfBirthCopy")]
        public DateTime DateOfBirthCopy { get; set; }

        public Teacher(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;

            FirstNameCopy = firstName;
            LastNameCopy = lastName;
            DateOfBirthCopy = dateOfBirth;
        }
        public Teacher() { }
        

        public override String ToString()
        {
            char[] word = DateOfBirthCopy.ToString().ToCharArray();
            string date = null;

            for (int i = 0; i <= word.Length / 2; ++i)
            {
                date += word[i];
            }
            return "Ім'я: " + FirstNameCopy + "; Прізвище: " + LastNameCopy + "; Дата народження: " + date;
        }
    }
}
