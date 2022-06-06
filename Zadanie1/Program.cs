using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program w konsoli, który znajdzie największą wartość w tablicy i wypisze ją
            //w konsoli.

            int[] tablicaLiczb = {15, 45, 10, 50, 10, 100, 21, 2};

            //tworzymy zmienną pomocniczną max = pierwsza liczba z tablicy
            //for który przechodzi po wszystkich elementach tablicy
            //w środku for musi być if który będzie porównywał liczby
            //sprawdzamy czy max < tabliczaLiczb[i]
            // jeżeli tak max = tabliczaLiczb[i]

            //wypisz max

            //ROZSZERZENIE ZADANIA

            //Dodać znajdowanie najmniejszej wartości w tablicy.

            int max = tablicaLiczb[0];
            int min = tablicaLiczb[0];
            for(int i = 0; i < tablicaLiczb.Length; i++)
            {
                if(max < tablicaLiczb[i])
                {
                    max = tablicaLiczb[i];
                }
                if(min > tablicaLiczb[i])
                {
                    min = tablicaLiczb[i];
                }
            }

            foreach(int x in tablicaLiczb)
            {
                if (max < x)
                {
                    max = x;
                }
                if (min > x)
                {
                    min = x;
                }
            }


            Console.WriteLine("Maksymalna wartość to: " + max);
            Console.WriteLine("Minimalna wartość to: " + min);
            Console.ReadLine();

        }
    }
}
