namespace ClassIntro.ClassExempel;

using System;

// En class kan innehålla statiska medlemmar.
internal static class ClassWithStaticMembers
{
    // Statisk konstant
    public static readonly string Constant = "Hello from constant";

    // Statisk egenskap
    public static string Text { get; set; }

    // Statisk metod
    public static void Print()
    {
        Console.WriteLine(Text);
    }
}


 // ---------------------------------------------------------------------