//Fråga användaren: "Vad är ditt namn?"
Console.WriteLine("Vad är ditt namn?");

//Hämta namnet från vad användaren skriver!
var name = Console.ReadLine();
var frukost = true;
var age = 20;

//Skriv ut "Hej! Ditt namn är (Vad användaren skrev in)"
Console.WriteLine($"Hej! Ditt namn är {name}, du är {age} år och..");
if(frukost) { Console.WriteLine("..du hade frukost!"); }
else { Console.WriteLine("..du hade inte frukost!"); }