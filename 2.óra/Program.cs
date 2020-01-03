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
            Feladat2(raktarlista);
            Feladat3(raktarlista);
            Console.ReadKey();
            
        }

        private static void Feladat3(List<Termek> raktarlista)
        {
            //A raktár tulajdonos szeretné tudni, hogy van-e JAGERMAISTER 1 L.
            //termék mert le szeretné akciózni, hogy aztán vegyen otthonra iszogatni.
            int i = 0;
            bool vane = false;
            while (i < raktarlista.Count && vane!=true)
            {
                i++;
                if (raktarlista[i].nev == "JAGERMAISTER 1 L. ")
                {
                    vane = true;
                }
            }
            if (vane==true)
            {
                Console.WriteLine("Van ilyen termék");
            }
            else
            {
                Console.WriteLine("Nincs ilyen termék a boltba");
            }
        }

        private static void Feladat2(List<Termek> raktarlista)
        {
            int db = 0;
            for (int i = 0; i <raktarlista.Count; i++)
            {
                if (raktarlista[i].afa !=27)
                {
                    db+=raktarlista[i].mennyiseg;
                }
            }
            Console.WriteLine(db + " elem van, aminek az áfája nem 27% ");
        }

        private static void Feladat1(List<Termek> raktarlista)
        {
            int S = 0;
            for (int i = 0; i < raktarlista.Count; i++)
            {
                S += raktarlista[i].mennyiseg;
            }
            Console.WriteLine(S +" darab termék van");
        }

        private static List<Termek> Beolvasas()
        {
            List<Termek> raktarlista = new List<Termek>();
            List<string> raktarlista2 = new List<string>();
            string[] raktarkeszlet;
            
            //raktarkeszlet2 = File.ReadAllLines(@"C:\Users\sgergo\source\repos\Tutorial\Segedanyagok\Raktarkeszlet.txt");
            raktarkeszlet = File.ReadAllLines(@"C:\Users\nemet\source\repos\szellgergo\Tutorial\Segedanyagok\Raktarkeszlet.txt");

            for (int i=0;i<raktarkeszlet.Length;i++) {

                string[] tomb=raktarkeszlet[i].Split(';');
                for (int j = 0; j < tomb.Length; j++)
                {
                    raktarlista.Add(new Termek {nev=tomb[0],vonalkod=Int32.Parse(tomb[1]),mennyiseg=Int32.Parse(tomb[2]),afa=Int32.Parse(tomb[3].Split(',')[0]), netto=double.Parse(tomb[4])});
                    raktarlista2.Add(tomb[j]);
                }
            }
            return raktarlista;
        }
    }
}
