namespace ClassIntro.ClassExempel;

/// <summary>
///  Class med property
///  Den hanterar värden men för användaren av klassen kommer
///  den att verka som en variabel. Den kommer inte att acceptera
///  att någon ålder mindre än 0 eller större än 150 matas in.
/// </summary>
/// Exempel på användning
/// Person b=new Person();
/// p.Name="Bruce Wayne";
/// p.Age=35;
/// p.Age = 300; // Felaktig ålder, kommer inte att accepteras
///              // åldern kommer att sättas till 150 automagiskt
public class Person
{
    // Lokala variabler (fält) som är bara tillgängliga för alla
    // i classen, men inte utanför
    private int age = 0;

    // Metod som beter sig som en variabel utanför classen
    // och tar emot / returnerar värde.
    public int Age
    {
        get => age;
        set => age = Check(value);  // Anropar kontroll innan värdet sparas
    }

    // Kan även skrivas som en auto-implementerad egenskap (property)
    // public int Age { get; set; }
    // men då kan man inte kontrollera input
    // Ett annat sätt att skriva det på är:
    // Public string Age
    // {
    //  get => age;
    //  set => name = Check(value);
    // }

    // Metod som beter sig som en variabel utanför classen
    // och tar emot / returnerar värde.
    public string Name { get; set; } = "Unknown";

    // Kan förenklas till detta: Public string Name {get;set;}
    // men då använder vi inte det privata fältet
    // Ett annat sätt att skriva det på är:
    // Public string Name
    // {
    //  get => name;
    //  set => name = value;
    // }

    // Metod som kontrollerar att åldern inte är felaktig
    private int Check(int value)
    {
        if (value < 0) value = 0;
        if (value > 150) value = 150;
        return value;
    }
}