Person batman = new Person()
{
    FirstName = "Bruce",
    LastName = "Wayne",
    Age = 35
};

internal class Person
{
    // Properties utan fält
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
}
