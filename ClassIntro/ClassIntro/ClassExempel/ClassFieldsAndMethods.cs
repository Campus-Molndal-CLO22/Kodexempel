namespace ClassIntro.ClassExempel;

using System;

// En class är en mall för att skapa objekt.
// En class kan innehålla fält, egenskaper, metoder, indexer, händelser och andra typer av medlemmar.
// Exempelkod för användning och instansiering
// ClassWithStuff classWithStuff = new ClassWithStuff();
// classWithStuff.Text = "Hello";
// classWithStuff.Print(); // Skriver ut "Hello"
internal class ClassFieldsAndMethods
{
    // Egenskaper = metod som ger externa klasser tillgång till variabeln
    public string? Text { get; set; }

    // Metoder
    public void Print()
    {
        Console.WriteLine(Text);
    }
}