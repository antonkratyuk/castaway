using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object [] { "Hello!", "1", 3, 2.00, 'a' };        

            Dictionary<string,int> dic = new Dictionary<string,int>();

            dic.Add("System.String", 0);
            dic.Add("System.Char", 0);
            dic.Add("System.Int32", 0);
            dic.Add("System.Double", 0);
            dic.Add("Others", 0);
            Counter ob = new Counter();
            ob.Count(arr, ref dic);

            ob.Display(dic);
        }
    }
}
