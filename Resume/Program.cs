using System;

namespace Resume
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Initialize the main menu
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        // This is gonna be real janky for now. I need sleep.
        // Show simple menu

        private static bool MainMenu()
        {
            // tossing a class in with resume info.
            ShowResume show = new ShowResume();

            // populate a basic menu. Will make this fancy later.
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Introduction");
            Console.WriteLine("2) Education");
            Console.WriteLine("3) Experience");
            Console.WriteLine("4) Contact");
            Console.WriteLine("5) FizzBuzz");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            // simple switch to grab user input. Need to get rid of the copy pasta later once brain functions again.
            switch (Console.ReadLine())
            {
                case "1":
                    show.Introduction();

                    Console.WriteLine("Press Enter to return to main menu.");
                    Console.ReadLine();
                    return true;
                case "2":
                    show.Education();

                    Console.WriteLine("Press Enter to return to main menu.");
                    Console.ReadLine();
                    return true;
                case "3":
                    show.Experience();

                    Console.WriteLine("Press Enter to return to main menu.");
                    Console.ReadLine();
                    return true;
                case "4":
                    show.Contact();

                    Console.WriteLine("Press Enter to return to main menu.");
                    Console.ReadLine();
                    return true;
                case "5":
                    FizzBuzz();

                    Console.WriteLine("Press Enter to return to main menu.");
                    Console.ReadLine();
                    return true;
                case "6":
                    return false;
                default:
                    return true;
            }
        }

        // Just for good measure. Had it laying around.
        private static void FizzBuzz()
        {
            for(int i = 1; i <= 100; i++)
            {
                string output = string.Empty;

                if(i % 15 == 0)
                {
                    output = "FizzBuzz";
                } else if(i % 3 == 0)
                {
                    output = "Fizz";
                } else if(i % 5 == 0)
                {
                    output = "Buzz";
                } else
                {
                    output = i.ToString();
                }

                Console.WriteLine(output);
            }
        }

    }

    
}
