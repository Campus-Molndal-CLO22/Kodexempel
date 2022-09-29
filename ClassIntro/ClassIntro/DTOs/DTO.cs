namespace ClassIntro.DTOs;

//
// ---------------------------------------------------------------------
// DTO
// ---------------------------------------------------------------------
// DTO som betyder Data Transfer Object
// Används för att skapa objekt som skickas runt i program och nätverk
// Innehåller bara data (properties)
// Har ingen logik (metoder)
// Bör inte användas i arv
//

internal class PeopleDTO
{
    public string Name { get; set; }
    public int Age { get; set; }
}


// ---------------------------------------------------------------------