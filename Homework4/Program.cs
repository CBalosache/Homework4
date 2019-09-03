using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOne = "Bob";
            string nameTwo = "Carly";
            Console.WriteLine(Comparison.CompareByName(nameOne, nameTwo));
            Console.WriteLine(Comparison.CompareByLength(nameOne,nameTwo));
            nameOne = "Carly";
            nameTwo = "Carly";
            Console.WriteLine(Comparison.CompareByName(nameOne, nameTwo));
            Console.WriteLine(Comparison.CompareByLength(nameOne, nameTwo));
            nameOne = "Edward";
            nameTwo = "Carly";
            Console.WriteLine(Comparison.CompareByName(nameOne, nameTwo));
            Console.WriteLine(Comparison.CompareByLength(nameOne, nameTwo));
            Console.Read();
        }
    }
    class Comparison
    {
        public string Name { get; set; }

        interface ICompareByName
        {
	        int CompareByName();
        }
        interface ICompareByLength
        {
	        int CompareByLength();
        }
        public static int CompareByName(string name1, string name2)
        {
            return string.Compare(name1, name2);
        }
        public static int CompareByLength(string name1, string name2)
        {
            if(name1.Length == name2.Length)
            {
                return 0;
            }
            else
            {
                if(name1.Length > name2.Length)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
