using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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

        public List<HouseOfCreativity> Information = new List<HouseOfCreativity>();

        private int numberOfGroup;

        public Filling(int numberOfStudent, List<HouseOfCreativity> Information)
        {
            InitializeComponent();
            comboBox1.Items.Add(Section.SectionType.малювання);
            comboBox1.Items.Add(Section.SectionType.танцювальний);
            comboBox1.Items.Add(Section.SectionType.моделювання);
            comboBox1.Items.Add(Section.SectionType.іграшка);

            this.numberOfGroup = numberOfStudent;
            this.Information = Information;
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Check();
                if (Checked())
                {
                   
                    Teacher teacher1 = new Teacher(textBox1.Text, textBox2.Text, (DateTime)DateOf.SelectedDate);
                    Group group1 = new Group(textBox4.Text, teacher1, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                    Section section1 = new Section((Section.SectionType)comboBox1.SelectedItem);
                    HouseOfCreativity house = new HouseOfCreativity(textBox4.Text, teacher1, group1, section1);
                    ListBox list1 = (ListBox)Application.Current.Windows[0].FindName("listBox1");
                    numberOfGroup += 1;
                    list1.Items.Add("Гурток №" + numberOfGroup);

                    HouseOfCreativity.InformationAdd(house);
                    foreach (TextBox tb in FindVisualChildren<TextBox>(Application.Current.Windows[3]))
                    {
                        tb.Background = Brushes.White;
                        tb.Text = null;

                    }
                    comboBox1.Items.Clear();
                    MessageBox.Show("Запис додано");
                }
                else
                {
                    MessageBox.Show("Exeption");

                }
                
               
            }
            catch
            {
                MessageBox.Show("Помилка");
            }
        }

        private void bnt_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
        readonly Regex NameReg = new Regex(@"^[a-zA-Zа-яА-Яа-яА-Я]+\s?$");
        
        readonly Regex Number = new Regex(@"^[\d]+$");

        public void Check()
        {
            if (NameReg.IsMatch(textBox1.Text))
            {
                textBox1.Background = Brushes.Green;              
            }
            else
            {
                textBox1.Background = Brushes.Red;
            }

            if (NameReg.IsMatch(textBox2.Text))
            {
                textBox2.Background = Brushes.Green;
            }
            else
            {
                textBox2.Background = Brushes.Red;
            }

            if (NameReg.IsMatch(textBox4.Text))
            {
                textBox4.Background = Brushes.Green;
            }
            else
            {
                textBox4.Background = Brushes.Red;
            }

            if (Number.IsMatch(textBox3.Text))
            {
                textBox3.Background = Brushes.Green;
            }
            else
            {
                textBox3.Background = Brushes.Red;
            }

            if (Number.IsMatch(textBox5.Text))
            {
                textBox5.Background = Brushes.Green;
            }
            else
            {
                textBox5.Background = Brushes.Red;
            }

            if (Number.IsMatch(textBox6.Text))
            {
                textBox6.Background = Brushes.Green;
            }
            else
            {
                textBox6.Background = Brushes.Red;
            }
        }

        public bool Checked()
        {
            bool ok = true;
            foreach (TextBox tb in FindVisualChildren<TextBox>(Application.Current.Windows[3]))
            {
                if (tb.Background == Brushes.Red) return false;
               
            }
            return ok;
        }

        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
    }
}
