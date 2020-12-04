using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolekcije2
{
    class Program
    {
        static void Main(string[] args)
        {
                List<int> brojevi = new List<int>();
                // Program traži unos cijelih brojeva
                while (true)
                {
                    Console.Write("Unesite cijeli broj:");
                    int broj = int.Parse(Console.ReadLine());
                    // Ako se unese 0, prekidamo unos
                    if (broj == 0)
                    {
                        break;
                    }
                    // Dodajemo broj u listu
                    brojevi.Add(broj);
                }
                brojevi.Sort(); // sortiramo elemente liste
                brojevi.Reverse(); // obrćemo redoslijed elemenata u listi
                // Ispisujemo elemente liste
                Console.WriteLine("Uneseni brojevi pad.redoslijedom:");
                foreach (int broj in brojevi)
                {
                    Console.Write("{ 0}, ", broj);
                }
                Console.ReadKey();
            }
        }
    }
