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
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public Edit()
        {
            InitializeComponent();
        }

        public List<HouseOfCreativity> information = new List<HouseOfCreativity>();
        public int index;
        public Edit(int index, List<HouseOfCreativity> Information)
        {
            InitializeComponent();

            comboBox1.Items.Add(Section.SectionType.малювання);
            comboBox1.Items.Add(Section.SectionType.танцювальний);
            comboBox1.Items.Add(Section.SectionType.моделювання);
            comboBox1.Items.Add(Section.SectionType.іграшка);

            this.index = index;
            this.information = Information;
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Teacher teacher1 = new Teacher(textBox1.Text, textBox2.Text, (DateTime)DateOf.SelectedDate);
                Group group1 = new Group(textBox4.Text, teacher1, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                Section section1 = new Section((Section.SectionType)comboBox1.SelectedItem);
                HouseOfCreativity house = new HouseOfCreativity(textBox4.Text, teacher1, group1, section1);
                
                information[index] = house;
                HouseOfCreativity.InformationCopy(information);
                this.Close();
               
            }
            catch
            {
                MessageBox.Show("Не все гаразд");
            }
        }

        private void bnt_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
