using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetLoaf_ReturnsLoaf_Int()
    {
      int loaf = 1;
      Bread newBread = new Bread(loaf);
      int result = newBread.Loaf;
      Assert.AreEqual(loaf, result);
    }

    [TestMethod]
    public void CalculateTotal_DeterminesTotalPrice_Int()
    {
      int loaf = 1;
      Bread newBread = new Bread(loaf);
      int numberOfLoafs = newBread.Loaf;
      int results = newBread.CalculateTotal(numberOfLoafs);
      Assert.AreEqual(5, results);
    }



    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastry1_ReturnsPastry1_Int()
    {
      int pastry1 = 1;
      Pastry newPastry = new Pastry(pastry1);
      int result = newPastry.Pastry1;
      Assert.AreEqual(pastry1, result);
    }

  }
}