/// <summary>
/// ------------------------------------------------------------------------------------
/// Swing on a Star skriven av Bing Brosby
/// Programmet skriver text och simulerar en skrivmaskin
/// vid output, genom att pausa mellan 10 och 500 millisekunder
/// ------------------------------------------------------------------------------------
/// Skrivet av Marcus Medina, för kursen i OOP i C# vid Campus Mölndal
/// Licenserad enligt Apache License 2.0, vilket innebär att du får använda 
/// koden som du vill så länge du inte tar bort denna kommentar
/// ------------------------------------------------------------------------------------
/// </summary>
namespace SwingOnAStar
{
    using System;

    static class Program
    {
        static void Main()
        {
            Console.CursorSize = 100;
            GenerateChorus(true); // Skriv ut intro

            GenerateVerse("mule"); // Skriv ut "mule" versen

            GenerateChorus(); // Skriv ut refrängen

            GenerateVerse("fish"); // Skriv ut "fish" versen

            GenerateOutro(); // Skriv ut Outro

            WriteLine(); // Generera tomrader
            WriteLine();
            WriteLine("--end"); // slut i rutan!
            WriteLine();
        }

        // Slutsång
        private static void GenerateOutro()
        {
            WriteLine("And all the monkeys aren't in the zoo");
            WriteLine("Every day you meet quite a few");
            WriteLine("So you see it's all up to you");
            WriteLine("You can be better than you are");
            WriteLine("You could be swingin' on a star");
        }

        // Skriv ut verserna
        private static void GenerateVerse(string animal)
        {
            WriteLine(animal);
            WriteLine();
            switch (animal)
            {
                case "mule":
                    WriteLine("A mule is an animal with long funny ears");
                    WriteLine("Kicks up at anything he hears");
                    WriteLine("His back is brawny but his brain is weak");
                    WriteLine("He's just plain stupid with a stubborn streak");
                    WriteLine("And by the way, if you hate to go to school");
                    break;
                case "pig":
                    WriteLine("A pig is an animal with dirt on his face");
                    WriteLine("His shoes are a terrible disgrace");
                    WriteLine("He has no manners when he eats his food");
                    WriteLine("He's fat and lazy and extremely rude");
                    WriteLine("But if you don't care a feather or a fig");
                    break;
                case "fish":
                    WriteLine("A fish won't do anything, but swim in a brook");
                    WriteLine("He can't write his name or read a book");
                    WriteLine("To fool the people is his only thought");
                    WriteLine("And though he's slippery, he still gets caught");
                    WriteLine("But then if that sort of life is what you wish");
                    break;
            }
            WriteLine($"You may grow up to be a {animal}");
            WriteLine();
        }

        // Skriv ut refrängen, om intro = true skriv det som intro
        static void GenerateChorus(bool isIntro = false)
        {
            Write(isIntro ? "Would" : "Or would"); // Om intro == sant skriv "Would", annars skriv "Or would"
            WriteLine(" you like to swing on a star");
            WriteLine("Carry moonbeams home in a jar");
            WriteLine("And be better off than you are");
            Write("Or would you rather be a ");
        }
        static Random random = new Random(); // Slumpgenerator

        // Shortcut för TypeWriterSimulator (string, bool), skriver och fortsätter att skriva bredvid
        private static void Write(string text = "")
        {
            TypeWriterSimulator(text, false);
        }

        // Shortcut för TypeWriterSimulator (string, bool), skriver och skapar ny rad
        private static void WriteLine(string text = "")
        {
            TypeWriterSimulator(text, true);
        }

        private static void TypeWriterSimulator(string text = "", bool newLine = true)
        {
            if (text == "")
            {
                Console.WriteLine();
                return;
            }

            // Simulate typewriter by pausing randomly and writing one or two chars
            char lastSymbol = ' ';
            foreach (char symbol in text)
            {
                int paus = random.Next(10, 300); // Hur många millisekunder pausen ska vara
                if (lastSymbol == symbol) // om tecknet upprepas
                {
                    Thread.Sleep(10); // pausa i 10 millisekunder
                }
                else if (random.Next(0, 100) > 50) // 50% chans att pausen skippas
                {
                    Thread.Sleep(paus); // gör en paus
                }
                Console.Write(symbol); // skriv ut ett tecken
            }

            if (newLine) // om newLine satts till true
            {
                Console.WriteLine(); // skriv ut en tomrad
            }

        }
    }
}
