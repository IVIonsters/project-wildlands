namespace projectWildlands
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("=== PROJECT WILDLANDS ===\n");
            System.Console.WriteLine("Welcome to the Wilderness Research Program.");

            string? explorerName = null;
            do
            {
                System.Console.Write("Let's Enter Your Name: ");
                explorerName = Console.ReadLine();
                if (explorerName is null)
                {
                    return;
                }
            } while (string.IsNullOrWhiteSpace(explorerName));

            System.Console.WriteLine("Welcome, Explorer " + explorerName + "\n");

            var adventureSelection = "";
            do
            {
                System.Console.WriteLine("Are you ready to begin your adventure? [Y] Yes [N] No");
                var input = Console.ReadLine();
                if (input is null)
                {
                    return;
                }
                adventureSelection = input.Trim().ToUpperInvariant();
                if (adventureSelection != "Y" && adventureSelection != "N")
                {
                    System.Console.WriteLine("Invalid input. Please enter Y or N ");
                }
            } while (adventureSelection != "Y" && adventureSelection != "N");
            if (adventureSelection == "Y")
            {
                System.Console.WriteLine("Your Selection: " + adventureSelection + "\n");
                System.Console.WriteLine("=== PROJECT WILDLANDS ===\n");
                System.Console.WriteLine("Welcome, " + explorerName + " Your adventure awaits");

                //Generate Creatures
                Creature emberfox = new Creature();
                emberfox.Name = "Emberfox";
                emberfox.Type = "Fire";
                emberfox.Level = 5;
                emberfox.CaptureDifficulty = 3;
                emberfox.description = "The fiery fox creature.";

                Creature mossling = new Creature();
                mossling.Name = "Mossling";
                mossling.Type = "Grass";
                mossling.Level = 3;
                mossling.CaptureDifficulty = 2;
                mossling.description = "The moss covered pig creature.";

                Creature aquafin = new Creature();
                aquafin.Name = "Aquafin";
                aquafin.Type = "Water";
                aquafin.Level = 7;
                aquafin.CaptureDifficulty = 5;
                aquafin.description = "The transparent fin creature.";

                //Game on Value
                bool keepPlaying = true;
                while (keepPlaying)
                {
                    System.Console.WriteLine("===== MAIN MENU =====\n");
                    System.Console.WriteLine("[1] Explore Wilderness");
                    System.Console.WriteLine("[2] Research Journal");
                    System.Console.WriteLine("[3] Inventory");
                    System.Console.WriteLine("[4] Exit Game");
                    System.Console.Write("Enter Your Choice: ");
                    var menuChoice = Console.ReadLine();
                    if (menuChoice is null)
                    {
                        return;
                    }
                    var userSelection = menuChoice.Trim();
                    switch (userSelection)
                    {
                        case "1":
                            System.Console.WriteLine("You venture into the wilderness...");
                            System.Console.WriteLine("===== WILD CREATURES =====\n");
                            System.Console.WriteLine($"Name: {emberfox.Name}");
                            System.Console.WriteLine($"Type: {emberfox.Type}");
                            System.Console.WriteLine($"Level: {emberfox.Level}");
                            System.Console.WriteLine(
                                $"Capture Difficulty: {emberfox.CaptureDifficulty}"
                            );
                            System.Console.WriteLine($"Description: {emberfox.description}");
                            System.Console.WriteLine("---");
                            System.Console.WriteLine($"Name: {mossling.Name}");
                            System.Console.WriteLine($"Type: {mossling.Type}");
                            System.Console.WriteLine($"Level: {mossling.Level}");
                            System.Console.WriteLine(
                                $"Capture Difficulty: {mossling.CaptureDifficulty}"
                            );
                            System.Console.WriteLine($"Description: {mossling.description}");
                            System.Console.WriteLine("---");
                            System.Console.WriteLine($"Name: {aquafin.Name}");
                            System.Console.WriteLine($"Type: {aquafin.Type}");
                            System.Console.WriteLine($"Level: {aquafin.Level}");
                            System.Console.WriteLine(
                                $"Capture Difficulty: {aquafin.CaptureDifficulty}"
                            );
                            System.Console.WriteLine($"Description: {aquafin.description}");
                            break;
                        case "2":
                            System.Console.WriteLine("Opening your research journal...");
                            break;
                        case "3":
                            System.Console.WriteLine("Opening Inventory....");
                            break;
                        case "4":
                            System.Console.WriteLine("Thank you playing Project Wildlands!");
                            keepPlaying = false;
                            break;
                        default:
                            System.Console.WriteLine("Invalid Input , Please Try Again!");
                            break;
                    }
                }
            }
            else
            {
                System.Console.WriteLine("We hope you return for your adventure soon!");
            }
        }
    }
}
