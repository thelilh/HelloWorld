//Fråga användaren: "Vad är ditt namn?"
Console.WriteLine("Vad är ditt namn?");
string consoleOutput;

//Hämta namnet från vad användaren skriver!
var name = Console.ReadLine();
consoleOutput = $"Hej! Ditt namn är {name}";

//Fråga användaren vad deras ålder är!
var age = 0;
var hasAge = false; //Har vi faktiskt fått åldern eller ljuger användaren för oss?
while(!hasAge) { 
    Console.WriteLine("Vad är din ålder?");
    //Är det ett nummer? Om ja, himla bra. Om ej, jäkla användare!
    var ageString = Console.ReadLine();
    bool isNumber = int.TryParse(ageString, out age); 
    switch(isNumber)
    {
        case true: 
            hasAge = true; 
            break;
        case false:
            Console.WriteLine($"Vad du skrev är inte ett nummer. Du skrev: {ageString}");
            break;
    }
}
consoleOutput += $" och du är {age} år";

//Fråga användaren om de åt frukost
var frukost = false; 
var hasFrukost = false; //Har vi faktiskt fått frukost "inputen"?
while (!hasFrukost)
{
    Console.WriteLine("Har du ätit frukost? (Y/N)");
    //Är det ett nummer? Om ja, himla bra. Om ej, jäkla användare!
    var ageString = Console.ReadLine();
    char ageChar = ageString.ToLower()[0];
    switch (ageChar)
    {
        case 'y':
            frukost = true;
            hasFrukost = true;
            break;
        case 'j':
            frukost = true;
            hasFrukost = true;
            break;
        case 'n':
            frukost = false;
            hasFrukost = true;
            break;
        default:
            Console.WriteLine($"Du behöver skriva Y/J eller N för YES/JA eller NO/NEJ. Du skrev {ageString}");
            break;
    }
}
switch(frukost)
{
    case true:
        consoleOutput += ". Idag hade du frukost, gött!";
        break;
    case false:
        consoleOutput += ". Idag hade du inte frukost, hoppas du klarar dig ändå!";
        break;
}
//Skriv ut consoleOutput
Console.WriteLine(consoleOutput);