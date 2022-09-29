namespace ClassIntro.POCOs;

// Att instansiera en class innebär att skapa ett objekt av den classen.
// Med andra ord skapas ett objekt av en class genom att använda nyckelordet new.
// Med att man skapar ett objekt menas att man skapar en körbar version av klassen
// Klassen i sig är inte körbar förrän den blivit ett objekt.
// Ett objekt skapas genom att vi använder ett av dess constructor
//
// Olika benämningar för classer är exempelvis
//
// ---------------------------------------------------------------------
// POCO
// ---------------------------------------------------------------------
// POCO som betyder Plain Old CLR Object, men även Plain Old C# Object
// Används för att skapa objekt som skickas runt i program och nätverk
// Innehåller bara data (properties)
// Har ingen logik (metoder)
// Bör inte användas i arv
// Oberoende av plattform
internal class Poco
{
    public string Name { get; set; }
    public int Age { get; set; }
}


 // ---------------------------------------------------------------------