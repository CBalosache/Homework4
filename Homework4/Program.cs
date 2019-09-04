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
            Comparison comp1 = new Comparison();
            Comparison comp2 = new Comparison();
            comp1.Name = "Cosmin";
            comp2.Name = "Balosache";
            Console.WriteLine(comp1.CompareByName(comp2));
            Console.WriteLine(comp1.CompareByLength(comp2));
            Console.Read();
        }
    }
    class Comparison : ICompareByName, ICompareByLength
    {
        public string Name { get; set; }
        public int CompareByName(object obj)
        {
            Comparison that = obj as Comparison;
            return string.Compare(this.Name, that.Name);
        }
        public int CompareByLength(object obj)
        {
            Comparison that = obj as Comparison;
            if (this.Name.Length == that.Name.Length)
            {
                return 0;
            }
            else
            {
                if (this.Name.Length > that.Name.Length)
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
    
    interface ICompareByName
    {
        int CompareByName(object o);
    }
    interface ICompareByLength
    {
        int CompareByLength(object o);
    }
}
