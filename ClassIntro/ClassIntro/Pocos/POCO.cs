namespace ClassIntro.Pocos;

// POCO = Plain Old C# Object
// En klass som bara innehåller fält och properties
// Ingen logik
internal class POCO
{
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
}