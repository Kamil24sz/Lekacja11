using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //tworzymy system rezewarcji biletów w kinie

            //1. Pytamy użytkownika na jaki film chce pójść
            // -tablica przechuwująca listę dostępnych filmów 

            string[] tablicaFilmów = { "Matrix", "Władca pierścieni", "Igrzyska śmierci"};

            //2.O co będziemy jeszcze pytać użytkownika?
            // -film
            // -imię
            // -nazwisko
            // - numer telefonu
            // -email 
            // - ilość biletów

            //informacje od użytkownika wypadłoby przewywać w jednej tablicy

            //możemy zadeklarować pustą tablicę podając ilość jej elementów
            string[] informacjeOdUżytkonika = new string[6];

            Console.WriteLine("Wybierz film na który chcesz pójść");
            for(int i = 0; i< tablicaFilmów.Length; i++)
            {
                Console.WriteLine(i+1 + " "+ tablicaFilmów[i]);
            }
            int numerFilmu = int.Parse(Console.ReadLine());

            informacjeOdUżytkonika[0] = tablicaFilmów[numerFilmu-1];

            //Pobieramy resztę danych

            Console.WriteLine("Podaj imię");
            informacjeOdUżytkonika[1] = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko");
            informacjeOdUżytkonika[2] = Console.ReadLine();

            Console.WriteLine("Podaj numer telefonu");
            informacjeOdUżytkonika[3] = Console.ReadLine();

            Console.WriteLine("Podaj email");
            informacjeOdUżytkonika[4] = Console.ReadLine();

            Console.WriteLine("Podaj ilość biletów");
            informacjeOdUżytkonika[5] = Console.ReadLine();

            //prezentacja danych, podsumowanie zamówienia

            string[] nagłówki = { "Film", "imię", "nazwisko", "numer telefonu", "email", "ilość biletów" };

            for(int a = 0; a<informacjeOdUżytkonika.Length; a++)
            {
                Console.WriteLine(informacjeOdUżytkonika[a]);
            }
        }
    }
}
