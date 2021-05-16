using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WpfApp_lab4
{
    [XmlType("Teacher")]
 
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

        public override String ToString()
        {
            char[] word = DateOfBirth.ToString().ToCharArray();
            string date = null;

            for (int i = 0; i <= word.Length / 2; ++i)
            {
                date += word[i];
            }
            return "Ім'я: " + FirstName + ";\nПрізвище " + LastName + ";\nДата народження " + date + ";";
        }
    }
}
