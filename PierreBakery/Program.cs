using System;
using PierreBakery.Models;
class Program
{
  static void Main()
  {
    Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    Console.WriteLine("Welcome to Pierres Bakery!");
    Console.WriteLine("Bread goes for $ 5 a Loaf, and Pastry are $2 each.");
    Console.WriteLine("Please enter in how many loaves of bread you want:");
    int loaves = Convert.ToInt32(Console.ReadLine());
    Bread newBread = new Bread(loaves);
    int numOfLoaves = newBread.Loaf; 
    Console.WriteLine("Please enter in how many pastries you want:");
    int pastries = Convert.ToInt32(Console.ReadLine());
    Pastry newPastry = new Pastry(pastries);
    int numOfPastries = newPastry.Pastries;
    int resultsForBread = newBread.CalculateTotal(numOfLoaves);
    int resultsForPastries = newPastry.CalculatePastryTotal(numOfPastries);
    int totalCost = resultsForBread + resultsForPastries;
    Console.WriteLine("Total Cost: $ " + totalCost);

  }



}
