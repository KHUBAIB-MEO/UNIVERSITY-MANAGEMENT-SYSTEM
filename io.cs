using System;

namespace IO
{
    class InputOutput
    {
        public void check()
        {
            string choice;
            while (true)
            {
                Console.WriteLine("Enter 1 for again login");
                Console.Write("Enter 0 for EXIT: ");
                choice = Console.ReadLine()!;
                switch (choice)
                {
                    case "0":
                        Environment.Exit(0);
                        break;

                    case "1":
                        return;

                    default:
                        Console.WriteLine("Wrong input Try again");
                        break;
                }
            }
        }
        public void check(bool back)
        {
            string choice;
            while (true)
            {
                Console.WriteLine("Enter 1 for again login");
                Console.Write("Enter 0 for EXIT: -");
                choice = Console.ReadLine()!;
                switch (choice)
                {
                    case "0":
                        Environment.Exit(0);
                        break;

                    case "1":
                        //code//
                        break;

                    default:
                        Console.WriteLine("Wrong input Try again");
                        break;
                }
            }
        }
    }
}