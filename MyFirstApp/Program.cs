using System;
using System.Xml;

namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fråga användaren: "Vad är ditt namn?"
            Console.WriteLine("Vad är ditt namn?");

            //Hämta namnet från vad användaren skriver!
            string? name = Console.ReadLine(); //string? då Console.ReadLine() krävde det.

            //Skriv ut "Hej! Ditt namn är (Vad användaren skrev in)"
            Console.WriteLine($"Hej! Ditt namn är {name}");
        }
    }
}