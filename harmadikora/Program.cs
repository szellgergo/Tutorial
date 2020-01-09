using System;
using System.Collections.Generic;
using System.IO;

namespace harmadikora
{
    class Program
    {
        static void Main(string[] args)
        {
            var ertek = Beolvasas();
            feladat1(ertek);
            feladat2(ertek);
            feladat3(ertek);
            feladat4(ertek);
            Console.ReadKey();
        }

        private static void feladat4(List<int> ertek)
        {
            //4.Kiválasztás tétele
           //Írassuk ki a console - ra az 5000 és a 6000 közötti legkisebb számról hogy  hányadik elem a tömbben.
          //Formátuma legyen: 5000 és a 6000 közötti legkisebb szám a 467 helyen található.
          int minhely = ertek[0];
            int eredmeny = 0;
            for (int i = 0; i < ertek.Count; i++)
            {
                if (5000<ertek[i] && ertek[i]<6000)
                {
                    if (ertek[i]<minhely)
                    {
                        minhely = i;
                    }
                }
            }
            Console.WriteLine("5000 és a 6000 közötti legkisebb szám a " + minhely + " helyen található");

        }

        private static void feladat3(List<int> ertek)
        {
            //3.Eldöntés tétele
            //Írassuk ki a console - ra az 5000 és a 6000 közötti legnagyobb számot.
            //Formátuma legyen: 5000 és a 6000 közötti legnagyobb szám az a 5511.
            int max = 0;
            for (int i = 0; i < ertek.Count; i++)
            {
                if (5000 < ertek[i] && ertek[i] < 6000)
                {
                    if (ertek[i] > max)
                    {
                        max = ertek[i];
                    }
                }
            }
            Console.WriteLine("5000 és a 6000 közötti legnagyobb szám az a " + max);
        }

        private static void feladat2(List<int> ertek)
        {
            //2.Megszámlálás tétele
            //Számoljuk össze hány darab olyan érték van amelyik 500 - nál kisebb, és írassuk ki a console - ra.
            //Formátuma legyen: Összesen 317 db 500 - nál kisebb érték található.
            int x = 0;
            for (int i = 0; i < ertek.Count; i++)
            {
                if (ertek[i]<500)
                {
                    x = x+ 1;
                }
            }
            Console.WriteLine("Összesen " + x + " db 500 - nál kisebb érték található");
        }

        private static void feladat1(List<int>ertek)
        {
            //Adjuk össze az első 100 számot és írassuk ki console-ra az eredményt.
            //Formátuma legyen: Ha az első 100 számot összeadjuk akkor 34318 kapunk
            int s = 0;
            for (int i = 0; i < 100; i++)
            {
                s += ertek[i];
            }
            Console.WriteLine("Ha az első 100 számot összeadjuk akkor " + s);
        }

        private static List<int> Beolvasas()
        {
            string eleres = @"C:\Users\nemet\source\repos\szellgergo\Tutorial\Segedanyagok\3. órai\Harmadikorai.txt";
            string[] tomb = File.ReadAllLines(eleres);
            var szamlista = new List<int>();
            for (int i = 0; i < tomb.Length; i++)
            {
                szamlista.Add(Int32.Parse(tomb[i].Split(' ')[0]));
            }
            return szamlista;
        }
    }
}
