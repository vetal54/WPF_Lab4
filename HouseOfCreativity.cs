using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WpfApp_lab4
{
    [XmlType("HouseOfCreativity")]
    [XmlInclude(typeof(Section)), XmlInclude(typeof(Teacher)), XmlInclude(typeof(Group)), XmlInclude(typeof(HouseOfCreativity))]
    [Serializable]
    public class HouseOfCreativity
    {
      
        public Teacher teacher2;
        [XmlElement("teacher2Copy")]
        public Teacher teacher2Copy { get; set; }

        public Group group2;
        [XmlElement("group2Copy")]
        public Group group2Copy { get; set; }

        public Section section2;
        [XmlElement("section2Copy")]
        public Section section2Copy { get; set; }
        private string Address { get; set; }
        [XmlElement("AddressCopy")]
        public string AddressCopy { get; set; }
        public int a;

        [XmlArray("information")]
        [XmlArrayItem("HouseOfCreativity")]
        public static List<HouseOfCreativity> information = new List<HouseOfCreativity>();

        public int NumberOfGroup()
        {
            return 1;
        }

        public override String ToString()
        {
            return teacher2 + "; \nГурток: " +  section2.sectionType + "; Адрес: " + AddressCopy + ";\n" + group2;
        }

        public HouseOfCreativity(int address)
        {
            this.a = address;
        }

        public static void InformationAdd(HouseOfCreativity Information)
        {
            information.Add(Information);
        }

        public static void InformationCopy(List<HouseOfCreativity> Information)
        {
            information = Information;
        }

        public static void InformationDelete( int index)
        {
            information.RemoveAt(index);
            //information = Information;
        }

        public HouseOfCreativity(string address, Teacher teacher, Group group, Section section)
        {
            this.Address = address;
            AddressCopy = address;
            this.teacher2 = teacher;
            teacher2Copy = teacher;
            this.group2 = group;
            group2Copy = group; 
            this.section2 = section;
            section2Copy = section;
        }

        public HouseOfCreativity() { }
    }
}
