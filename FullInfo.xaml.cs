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
    /// Interaction logic for FullInfo.xaml
    /// </summary>
    public partial class FullInfo : Window
    {
        public FullInfo()
        {
            InitializeComponent();
        }

        public List<HouseOfCreativity> information = new List<HouseOfCreativity>();

        public FullInfo(List<HouseOfCreativity> information)
        {
            InitializeComponent();
            this.information = information;
            for (int i = 0; i < information.Count; i++)
                listBox_FullInfo.Items.Add(information[i]);
        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {
            int index = listBox_FullInfo.SelectedIndex;
            string a = Convert.ToString(information[index]);
         
           
           
            string[] arr = a.Split(':', ';');
            Edit redact = new Edit(index, information);

            redact.textBox1.Text = arr[1];
            redact.textBox2.Text = arr[3];
            redact.DateOf.Text = arr[5];
            redact.textBox4.Text = arr[9];
            redact.textBox3.Text = arr[11];
            redact.textBox5.Text = arr[13];
            redact.textBox6.Text = arr[15];
            redact.comboBox1.Text = arr[7].Remove(0,1);
            (this).Hide();
            redact.ShowDialog();
           
           
        }

        private void btn_delet_Click(object sender, RoutedEventArgs e)
        {
            ListBox list1 = (ListBox)Application.Current.Windows[0].FindName("listBox1");
            Label label1 = (Label)Application.Current.Windows[0].FindName("label_count");
            HouseOfCreativity.InformationDelete(listBox_FullInfo.SelectedIndex);
            list1.Items.Remove(list1.Items[listBox_FullInfo.Items.Count - 1]);
            listBox_FullInfo.Items.Remove(listBox_FullInfo.SelectedItem);
             
            label1.Content = listBox_FullInfo.Items.Count;
        }
    }
}
