using System.Diagnostics;

using CLOHelper;

internal class Helper
{
    internal void Start()
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine("Hello, CLO22!");
            Console.WriteLine();
            Console.WriteLine("Vad vill du göra idag");

            Dictionary<string, string> menuUrls = Data.GetMenu();
            foreach(var item in menuUrls)
            {
                Console.WriteLine(item.Key);
            }

            var choice = AskForANumber(question: "Ditt val:", min: 1, max: menuUrls.Count-1);

            // open chrome and the url on the choosen menu item
            //Process.Start(@"Chrome", menuUrls.Values.ElementAt(choice - 1));
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", menuUrls.Values.ElementAt(choice - 1));
        }
    }

    private int AskForANumber(string question, int min, int max)
    {
        var number = 0;
        var valid = false;
        while(!valid)
        {
            Console.WriteLine();
            Console.Write(question);
            var input = Console.ReadLine();
            if(int.TryParse(input, out number))
            {
                if(number >= min && number <= max)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine($"Du måste ange ett tal mellan {min} och {max}");
                }
            }
            else
            {
                Console.WriteLine("Du måste ange ett tal");
            }
        }

        return number;
    }
}
