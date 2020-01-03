using System;
using System.IO;

namespace _2.óra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] raktarkeszlet;
            raktarkeszlet = File.ReadAllLines(@"C:\Users\nemet\source\repos\szellgergo\Tutorial\Segedanyagok\Raktarkeszlet.txt");
        }
    }
}
