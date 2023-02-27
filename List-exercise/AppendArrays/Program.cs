using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listWithArraysNumbers = new List<int>();
            String[] separator = { "|" };
            String[] separatorSpace = { " " };
            List<string> arrays = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).
                Reverse().ToList();

            foreach (var item in arrays)
                listWithArraysNumbers.AddRange(item.Split(separatorSpace, StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).ToList());
            Console.WriteLine(string.Join(" ", listWithArraysNumbers));
        }
    }
}
