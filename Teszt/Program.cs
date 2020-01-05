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
            
            try//Ez minden esetben lefut
            {
                Console.WriteLine("Én mindig lefutok");
                File.ReadAllLines(@"C:\Users\sgergo\source\repos\Tutorial\Segedanyagok\Raktarkeszlet.txt");
                Console.WriteLine("Én csak akkor futok le ha sikeres volt az első beolvasás");
            }
            catch (Exception e) {
                Console.WriteLine("Én csak akkor futok le ha sikertelen volt az első beolvasás");
                File.ReadAllLines(@"C:\Users\sgergo\source\repos\Tutorial\Segedanyagok\Raktarkeszlet.txt");
                Console.WriteLine("Én csak akkor futok le ha az első sikertelen lett de amásodik már nem");
            }
            
        }
    }
}
