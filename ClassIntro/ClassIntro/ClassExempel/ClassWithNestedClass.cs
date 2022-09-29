namespace ClassIntro.ClassExempel;

using System;

// En class kan innehålla andra klasser och strukturer.
// Exempelkod för användning och instansiering
// ClassWithNestedClass cwn = new ClassWithNestedClass();
// cwn.NestedClass=new NestedClass();
// cwn.NestedClass.Print();
internal static class ClassWithNestedClass
{
    // Nested class
    public class NestedClass
    {
        public void Print()
        {
            Console.WriteLine("Hello from nested class");
        }
    }
}


 // ---------------------------------------------------------------------