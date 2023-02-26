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
    int currentTotalCost = GenerateTotalAmount(numOfLoaves, numOfPastries);
    Console.WriteLine("Your Total Cost Is: $ " + currentTotalCost);
    ConfirmToContinueOrder(currentTotalCost);

    static void ConfirmToContinueOrder(int currentTotalCost)
    {  
      Console.WriteLine("Did you want to add more to your order? Enter 'yes' to proceed, or 'no' if you are finish");
      string userInput = Console.ReadLine();
      if (userInput == "yes")
      {
        int numOfLoaves = GetLoafAmount();
        int numOfPastries = GetPastriesAmount();
        int newTotalCost = GenerateTotalAmount(numOfLoaves, numOfPastries);
        int results = currentTotalCost + newTotalCost;
        Console.WriteLine("New Total Cost Is: $ " + results);
        ConfirmToContinueOrder(results);
      
      }
      else
      {
        Console.WriteLine("Well Have a Nice Day!:");
      }
    }

    static int GetLoafAmount()
    {
      Console.WriteLine("How many loaves of bread do you want:");
      int loaves = Convert.ToInt32(Console.ReadLine());
      Bread newBread = new Bread(loaves);
      int numOfLoaves = newBread.Loaf;
      int resultsForBread = newBread.CalculateBreadTotal(numOfLoaves);
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
