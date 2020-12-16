using System;

namespace ElephantSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            do
            {
                Console.Write("You pressed ");
                string strInput = Console.ReadLine();
                if (strInput == "1")
                {
                    Console.WriteLine("Calling lloyd.WhoAmI()");
                    lloyd.WhoAmI();
                }
                else if (strInput == "2")
                {
                    Console.WriteLine("Calling lucinda.WhoAmI()");
                    lucinda.WhoAmI();
                }
                else if (strInput == "3")
                {
                    Elephant temp;
                    temp = lucinda;
                    lucinda = lloyd;
                    lloyd = temp;
                    Console.WriteLine("References have been swapped");
                }
                else if (strInput == "4")
                {
                    lloyd = lucinda;
                    lloyd.EarSize = 4321;
                    lloyd.WhoAmI();
                }
                else if (strInput == "5")
                {
                    lucinda.SpeakTo(lloyd, "Hi, Lloyd");
                }
                else return;
                Console.WriteLine();

            } while (true);
        }
    }
}
