using System;
using PierreBakery.Models;
class Program
{
  static void Main()
  {
    Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    Console.WriteLine("Welcome to Pierres Bakery!");
    Console.WriteLine("Bread goes for $ 5 a Loaf, and Pastry are $2 each.");
    int numOfLoaves = GetLoafAmount();
    int numOfPastries = GetPastriesAmount();
    ConfirmToContinueOrder(GenerateTotalAmount(numOfLoaves, numOfPastries));

    static void ConfirmToContinueOrder(int totalCost)
    {
      Console.WriteLine("Total Cost Is: $ " + totalCost);
      Console.WriteLine("Did you want to add more to your order? Enter 'yes' to proceed, or 'no' if you are finish");
      string userInput = Console.ReadLine();
      if (userInput == "yes")
      {
        int numOfLoaves = GetLoafAmount();
        int numOfPastries = GetPastriesAmount();
        int newTotalCost = GenerateTotalAmount(numOfLoaves, numOfPastries);
        



      }
      else
      {
        Console.WriteLine("Have a nice day!:");
      }
    }

    static int GetLoafAmount()
    {
      Console.WriteLine("How many loaves of bread do you want:");
      int loaves = Convert.ToInt32(Console.ReadLine());
      Bread newBread = new Bread(loaves);
      int numOfLoaves = newBread.Loaf;
      int resultsForBread = newBread.CalculateTotal(numOfLoaves);
      return resultsForBread;

    }
    static int GetPastriesAmount()
    {
      Console.WriteLine("How many pastries do you want:");
      int pastries = Convert.ToInt32(Console.ReadLine());
      Pastry newPastry = new Pastry(pastries);
      int numOfPastries = newPastry.Pastries;
      int resultsForPastries = newPastry.CalculatePastryTotal(numOfPastries);
      return resultsForPastries;
    }

    static int GenerateTotalAmount(int numOfLoaves, int numOfPastries)
    {
      int totalCost = numOfLoaves + numOfPastries;
      return totalCost;
    }



  }
}
