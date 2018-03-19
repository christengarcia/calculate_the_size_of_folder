/*
 * C# Program to Calculate the Size of Folder
 */

using System;
using System.Linq;
using System.IO;

namespace calculate_the_size_of_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dInfo = new DirectoryInfo(@"C:/sri");
            long sizeOfDir = DirectorySize(dInfo, true);
            Console.WriteLine("Directory size in Bytes : " +
            "{0:N0} Bytes", sizeOfDir);
            Console.WriteLine("Directory size in KB : " +
            "{0:N2} KB", ((double)sizeOfDir) / 1024);
            Console.WriteLine("Directory size in MB : " +
            "{0:N2} MB", ((double)sizeOfDir) / (1024 * 1024));
            Console.ReadLine();
        }
    }
}
