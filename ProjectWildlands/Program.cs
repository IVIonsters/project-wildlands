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
        emberfox.Description = "The fiery fox creature.";

        Creature mossling = new Creature();
        mossling.Name = "Mossling";
        mossling.Type = "Grass";
        mossling.Level = 3;
        mossling.CaptureDifficulty = 2;
        mossling.Description = "The moss covered pig creature.";

        Creature aquafin = new Creature();
        aquafin.Name = "Aquafin";
        aquafin.Type = "Water";
        aquafin.Level = 7;
        aquafin.CaptureDifficulty = 5;
        aquafin.Description = "The transparent fin creature.";

        Creature zephyrpup = new Creature();
        zephyrpup.Name = "Zephyrpup";
        zephyrpup.Type = "Wind";
        zephyrpup.Level = 4;
        zephyrpup.CaptureDifficulty = 3;
        zephyrpup.Description = "The breezy hound creature.";

        Creature pebbleback = new Creature();
        pebbleback.Name = "Pebbleback";
        pebbleback.Type = "Earth";
        pebbleback.Level = 6;
        pebbleback.CaptureDifficulty = 4;
        pebbleback.Description = "The stone-shelled tortoise creature.";

        //Create List 
        List<Creature> creatures = new List<Creature> { };
        creatures.Add(emberfox);
        creatures.Add(mossling);
        creatures.Add(aquafin);
        creatures.Add(zephyrpup);
        creatures.Add(pebbleback);

        //Creature List Testing - Disable / Enable as needed
        // foreach (var creature in creatures)
        // {
        //   System.Console.WriteLine(creature.Name);
        // }

        //Random Creature Roll Creation
        Random rng = new Random();


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
              System.Console.WriteLine("Searching for wild creatures...");
              System.Console.WriteLine("!!! WILD ENCOUNTER FOUND !!!\n");

              //Random Creature Generation
              int randomCreature = rng.Next(creatures.Count);
              var encounteredCreature = creatures[randomCreature];
              System.Console.WriteLine($"A wild {encounteredCreature.Name} has appeared!");
              System.Console.WriteLine("===== CREATURE DISCOVERED =====\n");
              System.Console.WriteLine($"Name: {encounteredCreature.Name}\nType: {encounteredCreature.Type}\nLevel: {encounteredCreature.Level}\nCapture Difficulty: {encounteredCreature.CaptureDifficulty}\nDescription: {encounteredCreature.Description}");
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
