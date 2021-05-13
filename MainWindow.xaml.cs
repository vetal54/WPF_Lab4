using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a = textBox1.Text;
            if (a != "")
            {
                comboBox1.Items.Add(a);
                listBox1.Items.Add(a);
                textBox1.Text = null;
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            string b;
            Window1 window1 = new Window1();
            window1.ShowDialog();
            if (HouseOfCreativity.aaa != null)
            {
                comboBox1.Items.Add(HouseOfCreativity.aaa);
                listBox1.Items.Add(HouseOfCreativity.aaa);
            }
        }
    }
}
