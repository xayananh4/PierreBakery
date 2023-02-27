using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace Bakery.Tests
{
  // TEST FOR BREAD CLASS 

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryQuantity_ReturnsPastryQuantity_Int()
    {
      int pastries = 1;
      Pastry newPastry = new Pastry(pastries);
      int result = newPastry.Quantity;
      Assert.AreEqual(pastries, result);
    }








    // [TestMethod]
    // public void CalculatePastryTotal_DeterminesTotalPrice_Int()
    // {
    //   int pastries = 5;
    //   Pastry newPastry = new Pastry(pastries);
    //   int numberofPastries = newPastry.Pastries;
    //   int results = newPastry.CalculatePastryTotal(numberofPastries);
    //   Assert.AreEqual(8, results);
    // }
  }
}