namespace ClassIntro.ClassExempel;
// Class med indexer beter sig som en array
// Exempelkod för användning och instansiering
// ClassWithIndexer cwi = new ClassWithIndexer();
// cwi[0] = "Hello";
// cwi[1] = "World";
internal class ClassWithIndexer
{
    // Indexer
    private readonly string[] text = new string[10];

    public string this[int index]
    {
        get => text[index];
        set => text[index] = value;
    }
}


 // ---------------------------------------------------------------------