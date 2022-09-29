namespace ClassIntro.ClassExempel;

using System;

// En class kan innehålla konstanter, fält, indexer, egenskaper, metoder, händelser och operatörer.
// Exempelkod för användning och instansiering
// ClassWithConstantsEventsAndOperators cwceao=new ClassWithConstantsEventsAndOperators();
// cwceao.Event += MinMetod();
// cwceao = cwceao + 1;
internal class ClassWithConstantsEventsAndOperators
{
    // Konstanter
    public const string Constant = "Hello from constant";

    // Händelser
    public event EventHandler Event;

    public int value { get; set; }

    public ClassWithConstantsEventsAndOperators() => value = 0;

    public ClassWithConstantsEventsAndOperators(int value) => Value = value;

    // Operatörer
    public static ClassWithConstantsEventsAndOperators operator +(ClassWithConstantsEventsAndOperators a, ClassWithConstantsEventsAndOperators b)
    {
        return new ClassWithConstantsEventsAndOperators(a.Value + b.Value);
    }
}


 // ---------------------------------------------------------------------