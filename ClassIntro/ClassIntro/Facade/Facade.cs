namespace ClassIntro.Facade;

// En facade är en klass som innehåller en samling metoder
// som är menade att göra det enklare att använda en annan klass
// Man använder detta för att hantera drivrutiner eller specifika
// lösningar som kanske kommer från en annan leverantör.
// Till exempel om ens mjukvar ska samarbeta med någon annan tillverkares
// mjukvara.
internal class Facade
{
    public List<string> AskDatabase(string query)
    {
        return new List<string>();
    }

    public string SaveToDatabase(string[] data)
    {
        return "";
    }

    public int GetStatisticsFor(string query)
    {
        return 0;
    }
}