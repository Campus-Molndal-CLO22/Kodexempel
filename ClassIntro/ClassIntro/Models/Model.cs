namespace ClassIntro.Models;

using System.ComponentModel.DataAnnotations;

// Model är en klass som representerar en rad i en tabell i en databas
// Den innehåller alltså alla kolumner i tabellen
// Databasen skapar automatiskt en nyckel för varje rad
// Denna nyckel kallas för Id och är en unik identifierare för varje rad
internal class Model
{
    [Key]
    private readonly long Id;

    public string? Name { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
}