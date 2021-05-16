using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp_lab4
{
    public class HouseOfCreativity
    {
      
        public Teacher teacher2;
        public Group group2;
        public Section section2;
        private string Address { get; set; }
        public int a;

        public List<HouseOfCreativity> information = new List<HouseOfCreativity>();

        public int NumberOfGroup()
        {
            return 1;
        }

        public override String ToString()
        {
            return "Ім'я" + teacher2.FirstNameCopy + "Прізвище" + teacher2.LastNameCopy + "Гурток" +  section2.sectionType + "Адрес" + Address;
        }

        public HouseOfCreativity(int address)
        {
            this.a = address;
        }

        public HouseOfCreativity(string address, Teacher teacher, Group group, Section section)
        {
            this.Address = address;
            this.teacher2 = teacher;
            this.group2 = group;
            this.section2 = section;
        }
    }
}
