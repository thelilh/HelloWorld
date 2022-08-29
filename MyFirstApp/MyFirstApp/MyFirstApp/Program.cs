using System;
using System.Xml;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är ditt namn?");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hej! Ditt namn är {name}");
        }
    }
}