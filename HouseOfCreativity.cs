using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp_lab4
{
    public class HouseOfCreativity
    {
       public static string aaa;
        private string Address { get; set; }

        public List<HouseOfCreativity> information = new List<HouseOfCreativity>();

        public int NumberOfGroup()
        {
            return 1;
        }

        public void ToShortString()
        {
            
        }

        public static void Name(string b)
        {
            aaa = b;
        }
    }
}
