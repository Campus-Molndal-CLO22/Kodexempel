namespace ClassIntro.Extensions;

// Extension metoder är metoder som vi kan lägga till i en klass
// De är statiska metoder som ser ut som om de tillhörde en annan klass
// Exempelkod för användning och instansiering
//
// string text = "Hello";
// text.Print(); // Skriver ut "Hello"
//
// Första parametern måste vara "this" följt av klassen
// om vi vill lägga till metoden i
internal static class Extension
{
    public static void Print(this string text)
    {
        Console.WriteLine(text);
    }
}