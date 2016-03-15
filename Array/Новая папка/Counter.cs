using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Counter
    {
        //public void Count(object[]array)
        //{
        //    foreach(var key in array)
        //    {
        //        switch(key.GetType().ToString())
        //        {
        //            case "System.String":
        //                ++str;
        //            break;

        //            case "System.Char":
        //                ++ch;
        //            break;

        //            case "System.Int32":
        //                ++Int;
        //            break;

        //            case "System.Double":
        //                ++Double;
        //            break;

        //            default:
        //                ++Default;
        //            break;


        //        }

        //    }
        //    Console.WriteLine("We have {0} strings, {1} chars, {2} integers, {3} doubles, {4} others",str,ch,Int,Double,Default);
        //}

        //int str = 0;
        //int ch = 0;
        //int Int = 0;
        //int Double = 0;
        //int Default =0;

        public void Count(object[]arr,ref Dictionary<string,int>arr1)
        {
            foreach (var key in arr)
            {
                switch (key.GetType().ToString())
                {
                    case "System.String":
                        ++arr1["System.String"];
                        break;

                    case "System.Char":
                        ++arr1["System.Char"];
                        break;

                    case "System.Int32":
                        ++arr1["System.Int32"];
                        break;

                    case "System.Double":
                        ++arr1["System.Double"];
                        break;

                    default:
                        ++arr1["Others"];
                        break;
                }

            }
        }

        public void Display(Dictionary<string, int>dic)
        {
            if(dic.Count==0)
                Console.WriteLine("Is empty");
            else
            {
                Console.WriteLine("There are :\n");
                foreach(var key in dic)
                {
                    Console.WriteLine(key.Key + ": " + key.Value.ToString());
                }
            }
        }

    }
}
