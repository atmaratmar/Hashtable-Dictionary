using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable_
{
    class Program
    {
        #region Difference between Hashtable and Dictionary
        /*Difference between Hashtable and Dictionary
          C# Dictionary and Hashtable
          Hashtable and Dictionary are collection of data structures
          to hold data as key-value pairs. Dictionary is generic type,
          hash table is not a generic type. The Hashtable is a weakly
          typed data structure, so you can add keys and values of any
          Object Type to the Hashtable. The Dictionary class is a strongly
          types < T Key, T Value > and you must specify the data types
          for both the key and value.*/
        #endregion
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            hash.Add(37, "atmar");
            hash.Add(23, "dilaqa");
            hash.Add(24, "Khushbo");
            hash.Add(20, "Somen");
            hash.Add(18, "Bahista");
            hash.Add(3, "Jazmin");
            foreach (int item in hash.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(hash[24]);
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(37, "atmar");
            dic.Add(23, "dilaqa");
            dic.Add(24, "Khushbo");
            dic.Add(20, "Somen");
            dic.Add(18, "Bahista");
            dic.Add(3, "Jazmin");
            foreach (int item in dic.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dic[23]);

        }
    }
}
