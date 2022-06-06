using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekacja11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ocena1 = 4;
            int ocena2 = 5; 
            int ocena3 = 6;

            //tablice są strukturą danych służącą do przechowywania zbiorów zmiennych 
            //można za ich pomocą przychowywać wiele zmiennych (wartości) na raz

            //TABLICE deklaracja  (poniższe zapisy są równoważne)
            int[] oceny = { 4, 5, 6}; 

            int[] oceny2 = new int[] { 4, 5, 6 };

            int[] oceny3 = new int[3];
            oceny3[0] = 4;
            oceny3[1] = 5;
            oceny3[2] = 6;

            for(int i = 0; i < oceny.Length; i++)
            {
                Console.WriteLine(oceny[i]);
            }

            //System.IndexOutOfRangeException - oznacza błąd przekroczenia indeksu w tablicy, indesks do któego się odwołujemy nie istnieje 
            //Console.WriteLine(oceny[3]);

            //oceny.Length  właściwiość length zwraca długość tablicy 


            //pętla, mechanizm foreach służy do przechodzenia po każdym elemencie tablicy
            //różni się od zwykłego fora tym, że odwołuje się do ELELEMNTÓW tablicy zamiast do INDEKSÓW tak jak w pętli for
            foreach (int i in oceny)
            {
                Console.WriteLine(i);
            }

            string[] napisy = { "a", "b", "c" };

            foreach (string i in napisy)
            {
                Console.WriteLine(napisy[i]);
            }

            Console.ReadLine();

        }
    }
}
