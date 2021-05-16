using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp_lab4
{
    /// <summary>
    /// Interaction logic for Filling.xaml
    /// </summary>
    public partial class Filling : Window
    {
        public Filling()
        {
            InitializeComponent();
        }

        private int numberOfStudent = 0;

        public Filling(int numberOfStudent)
        {
            InitializeComponent();
            comboBox1.Items.Add(Section.SectionType.малювання);
            comboBox1.Items.Add(Section.SectionType.танцювальний);
            comboBox1.Items.Add(Section.SectionType.моделювання);
            comboBox1.Items.Add(Section.SectionType.іграшка);

            this.numberOfStudent = numberOfStudent;
            
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Teacher teacher1 = new Teacher(textBox1.Text, textBox2.Text, (DateTime)DateOf.SelectedDate);
                Group group1 = new Group(textBox6.Text, (Section)comboBox1.SelectedItem, teacher1, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                Section section1 = new Section((Section.SectionType)comboBox1.SelectedItem);
                HouseOfCreativity house = new HouseOfCreativity(textBox4.Text,teacher1,group1,section1);
                ListBox list1 = (ListBox)Application.Current.Windows[0].FindName("listBox1");
                list1.Items.Add(house);
            }
            catch
            {

            }
        }
    }
}
