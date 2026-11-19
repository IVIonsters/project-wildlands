namespace projectWildlands
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("=== PROJECT WILDLANDS ===");
      System.Console.WriteLine("Welcome to the Wilderness Research Program.");
      System.Console.Write("Lets Enter Your Name: ");

      var explorerName = Console.ReadLine();
      System.Console.WriteLine("Welcome, Explorer " + explorerName);

    }
  }
}