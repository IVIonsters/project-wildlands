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
