using System;
using System.Collections.Generic;
using System.IO;

namespace _2.óra
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Termek> raktarlista = new List<Termek>();
            raktarlista = Beolvasas();
            
            Feladat1(raktarlista);
            
        }

        private static void Feladat1(List<Termek> raktarlista)
        {
            
        }

        private static List<Termek> Beolvasas()
        {
            List<Termek> raktarlista = new List<Termek>();
            List<string> raktarlista2 = new List<string>();
            string[] raktarkeszlet;
            raktarkeszlet = File.ReadAllLines(@"C:\Users\sgergo\source\repos\Tutorial\Segedanyagok\Raktarkeszlet.txt");
            for (int i=0;i<raktarkeszlet.Length;i++) {

                string[] tomb=raktarkeszlet[i].Split(';');
                for (int j = 0; j < tomb.Length; j++)
                {
                    Console.WriteLine(tomb[j]);
                    raktarlista.Add(new Termek {nev=tomb[0],vonalkod=Int32.Parse(tomb[1]),mennyiseg=Int32.Parse(tomb[2]),afa=Int32.Parse(tomb[3].Split(',')[0]), netto=double.Parse(tomb[4])});
                    raktarlista2.Add(tomb[j]);
                }
            }
            return raktarlista;
        }
    }
}
