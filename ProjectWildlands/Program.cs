namespace projectWildlands
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("=== PROJECT WILDLANDS ===\n");
            System.Console.WriteLine("Welcome to the Wilderness Research Program.");

            var explorerName = "";
            do
            {
                System.Console.Write("Let's Enter Your Name: ");
                explorerName = Console.ReadLine();
            } while (explorerName == null || explorerName == "");

            System.Console.WriteLine("Welcome, Explorer " + explorerName + "\n");
            System.Console.WriteLine("Are you ready to begin your adventure? [Y] Yes [N] No");
            //Add if statements
            var adventureSelection = Console.ReadLine();
            if (adventureSelection == "Y" || adventureSelection == "y")
            {
                System.Console.WriteLine("Your Selection: " + adventureSelection + "\n");
                System.Console.WriteLine("Your adventure awaits");
            }
            else if (adventureSelection == "N" || adventureSelection == "n")
            {
                System.Console.WriteLine("Your adventure awaits your return!");
            }
            else
            {
                System.Console.WriteLine("Invalid Input Restart");
            }
        }
    }
}
