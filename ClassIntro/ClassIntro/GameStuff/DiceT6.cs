namespace ClassIntro.GameStuff;

// Mer specifik tärning, T6
internal class DiceT6
{
    public int Value { get; private set; } // Skrivskyddad
    protected int MaxValue = 6; // Maxvärde, privat för alla utom de som ärver

    // Kasta tärningen
    public int Roll()
    {
        var r = new Random();
        Value = r.Next(1, MaxValue + 1);
        return Value;
    }
}