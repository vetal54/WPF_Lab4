using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace WpfApp_lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string loadFileBin = Directory.GetCurrentDirectory() + "\\Serializable\\Save.txt";
        private string loadFileXml = Directory.GetCurrentDirectory() + "\\Serializable\\Save.xml";
        private string loadFileJson = Directory.GetCurrentDirectory() + "\\Serializable\\Save.json";

        public FullInfo fullInfo;
      
        public List<HouseOfCreativity> information = new List<HouseOfCreativity>();

        public MainWindow()
        {
            InitializeComponent();
           
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            //HouseOfCreativity house = new HouseOfCreativity(11);
            
            Filling FillingInformation = new Filling(listBox1.Items.Count, information);
            fullInfo = new FullInfo();
            
            FillingInformation.ShowDialog();
            label_count.Content = listBox1.Items.Count;
        }

        private void btn_info_Click(object sender, RoutedEventArgs e)
        {
            label_count.Content = listBox1.Items.Count;
            fullInfo = new FullInfo(HouseOfCreativity.information);
            fullInfo.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HouseOfCreativity.InformationDelete(Convert.ToInt32(listBox1.SelectedIndex));
            listBox1.Items.Remove(listBox1.Items[listBox1.Items.Count-1]);
            label_count.Content = listBox1.Items.Count;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<HouseOfCreativity>), new Type[] { typeof(Section), typeof(Teacher), typeof(Group), typeof(HouseOfCreativity) });

                FileStream fsXML = new FileStream(loadFileXml, FileMode.Open);

                List<HouseOfCreativity> information = new List<HouseOfCreativity>();
                try
                {
                    information = xmlFormatter.Deserialize(fsXML) as List<HouseOfCreativity>;
                    fsXML.Close();
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                int index = 0;
                FullInfo info = new FullInfo();

                foreach (var locality in information)
                {
                    index += 1;
                    listBox1.Items.Add("Гурток №" + index);
                    //info.listBox_FullInfo.Items.Add(locality);
                }
                HouseOfCreativity.InformationCopy(information);
                label_count.Content = information.Count;
                //info.listBox_FullInfo.Items.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Зберегти зміни?", "Serialisation", MessageBoxButton.YesNoCancel);

            if (result == MessageBoxResult.Yes)
            {
                List<HouseOfCreativity> list = new List<HouseOfCreativity>();
                foreach (var loc in HouseOfCreativity.information)
                {
                    list.Add(loc);
                }
                XmlSerializer xmlFormatter = new XmlSerializer(typeof(List<HouseOfCreativity>), new Type[] { typeof(Section), typeof(Teacher), typeof(Group), typeof(HouseOfCreativity) });

                //FileStream fsBinary = new FileStream(loadFileBin, FileMode.Create);
                FileStream fsXML = new FileStream(loadFileXml, FileMode.Create);
                //BinaryFormatter formatter = new BinaryFormatter();

                try
                {
                    string json = JsonConvert.SerializeObject(list);
                    File.WriteAllText(loadFileJson, json);
                    //formatter.Serialize(fsBinary, list);
                    xmlFormatter.Serialize(fsXML, list);
                    //fsBinary.Close();
                    fsXML.Close();
                    Close();
                }
                catch (SerializationException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
            if (result == MessageBoxResult.No)
            {
                Close();
            }
        }
    }
}
