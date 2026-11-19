namespace projectWildlands
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("=== PROJECT WILDLANDS ===\n");
      System.Console.WriteLine("Welcome to the Wilderness Research Program.");
      System.Console.Write("Let's Enter Your Name: ");

      var explorerName = Console.ReadLine();
      System.Console.WriteLine("Welcome, Explorer " + explorerName + "\n");
      System.Console.WriteLine("Are you ready to begin your adventure? [Y] Yes [N] No");
      var adventureSelection = Console.ReadLine();

      System.Console.WriteLine("Your Selection: " + adventureSelection + "\n");
      System.Console.WriteLine("Your adventure awaits");

    }
  }
}