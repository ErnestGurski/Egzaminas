using System;

namespace Vytautes
{
    class Program
    {
        private const int peomWidth = 48;

        private static string[] poem = {   "Had I the heaven’s embroidered cloths,",
                                    "Enwrought with golden and silver light,",
                                    "The blue and the dim and the dark cloths",
                                    "Of night and light and the half-light,",
                                    "I would spread the cloths under your feet:",
                                    "But I, being poor, have only my dreams;",
                                    "I have spread my dreams under your feet;",
                                    "Tread softly because you tread on my dreams."};

        private static void PrintStarLine()
        {
            Console.WriteLine(new String('*', peomWidth));
        }

        private static void PrintTextLeft(string text)
        {
            Console.WriteLine("* {0, " + ((peomWidth - 4) * -1) + "} *", text);
        }
        private static void PrintTextRight(string text)
        {
            Console.WriteLine("* {0, " + (peomWidth - 4) + "} *", text);
        }


        private static void PrintPoem()
        {
            PrintStarLine();

            PrintTextLeft(poem[0]);
            PrintTextRight(poem[1]);
            PrintTextLeft(poem[2]);
            PrintTextRight(poem[3]);
            PrintTextLeft(poem[4]);
            PrintTextRight(poem[5]);
            PrintTextLeft(poem[6]);
            PrintTextLeft(poem[7]);

            PrintStarLine();
            PrintTextLeft(new String(' ', 5) + "Poet: William Butler Yeats");
            PrintTextRight("Published: 1899");
            PrintStarLine();
        }

        private static void CalculateExpresion()
        {
            for (int x = -750; x <= 300; x += 25)
            {
                double y = Math.Pow(x, 3) - 5 * Math.Pow(x, -3) + 14 * x;
                Console.WriteLine("When X = " + x + " then Y =" + y);
            }
        }

        private static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please select program:");
                Console.WriteLine("1. Print poem");
                Console.WriteLine("2. Calculate expresion");
                Console.WriteLine();
                Console.WriteLine("To end program enter TERMINATE");

                switch (Console.ReadLine())
                {
                    case "1":
                        PrintPoem();
                        break;
                    case "2":
                        CalculateExpresion();
                        break;
                    case "TERMINATE":
                        return;
                    default:
                        Console.WriteLine("No such command");
                        break;
                }
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
