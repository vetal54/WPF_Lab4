using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WpfApp_lab4
{
    [XmlType("Section")]
    [Serializable]

    public class Section
    {
        public enum SectionType
        {
            [XmlEnum(Name = "малювання")] малювання = 1, [XmlEnum(Name = "танцювальний")] танцювальний, [XmlEnum(Name = "моделювання")] моделювання, [XmlEnum(Name = "м'яка іграшка")] іграшка
        }

        [XmlElement("sectionType")]
        public SectionType sectionType;

        public Section()
        {
            sectionType = new SectionType();
        }

        public Section(SectionType sectionType)
        {
            this.sectionType = sectionType;
        }

        public override String ToString()
        {
            return "Гурток: " + sectionType + ";";
        }
    }
}
