namespace ClassIntro.GameStuff;

// T20 ärver T6 men ändrar värdet för MaxValue till 20
// Den får tillgång till allt publikt och Protected
// och behöver inte skapa om koden.
internal class DiceT20 : DiceT6
{
    public DiceT20() => MaxValue = 20;
}