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
    }
}
