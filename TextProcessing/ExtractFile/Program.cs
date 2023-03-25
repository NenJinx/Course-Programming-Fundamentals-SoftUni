using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] separator = { "\\" };
            String[] separatorOne = { "." };
            string filePath = Console.ReadLine();
            int lastIndexWithSlash = filePath.LastIndexOf('\\');
            //string substr = filePath.Substring(lastIndexWithSlash + 1, filePath.Length- 1 - lastIndexWithSlash);
            string[] substr = filePath.Substring(lastIndexWithSlash + 1, filePath.Length - 1 - lastIndexWithSlash).
                Split(separatorOne,StringSplitOptions.RemoveEmptyEntries);
            string fileName = substr[0];
            string fileExtension = substr[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}



