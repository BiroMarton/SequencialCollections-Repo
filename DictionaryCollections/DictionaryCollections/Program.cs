using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table["0"] = "Zero";
            table["1"] = "One";
            table["2"] = "Two";
            table["3"] = "Three";
            table["4"] = "Four";
            table["5"] = "Five";
            table["6"] = "Six";
            table["7"] = "Seven";
            table["8"] = "Eight";
            table["9"] = "Nine";

            string ourNumber = "377-476-2188";

            foreach(char c in ourNumber)
            {
                string digit = c.ToString();

                if (table.ContainsKey(digit))
                {
                    Console.WriteLine(table[digit]);
                }
            }

            Console.ReadLine();

        }
    }
}
