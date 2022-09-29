namespace ClassIntro.GameStuff;

// En tärning
internal class Dice
{
    // Skrivskyddad property, den har bara "get" och inte "set"
    public int Value { get; private set; }

    // Rulla tärningen
    public int Roll()
    {
        var r = new Random();
        Value = r.Next(1, 7);
        return Value;
    }
}