using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szia");
            File.ReadAllLines(@"C:\Users\sgergo\source\repos\Tutorial\Segedanyagok\Raktarkeszlet.txt");
        }
    }
}
