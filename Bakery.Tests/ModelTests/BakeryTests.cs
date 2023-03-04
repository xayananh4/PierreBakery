using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace Bakery.Tests
{
  // TEST FOR BREAD CLASS 

  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    //NEW TEST FOR QUANTITY PROPERTY 
    [TestMethod]
    public void GetQuantiy_ReturnsQuantiy_Int()
    {
      int quantity = 1;
      Bread newTriangle = new Bread(quantity);
      int result = newTriangle.Quantity;
      Assert.AreEqual(quantity, result);
    }

    // Test the calulate total function 
    [TestMethod]
    public void CalTotal_DeterminestheTotalPrice_Int()
    {
      int quantity = 1;
      Bread newBread = new Bread(1);
      int results = newBread.CalTotal(quantity);
      Assert.AreEqual(5, results);
    }
 
    // Test the calulate total with the discount applied  
    public void Cal_Total_DeterminesDiscountPrice_Int()
    {
      int quantity = 3;
      Bread newBread = new Bread(3);
      int results = newBread.CalTotal(quantity);
      Assert.AreEqual(10, results);
    }



    // [TestMethod]
    // public void GetLoaf_ReturnsLoaf_Int()
    // {
    //   int loaf = 1;
    //   Bread newBread = new Bread(loaf);
    //   int result = newBread.Loaf;
    //   Assert.AreEqual(loaf, result);
    // }

    // [TestMethod]
    // public void CalculateTotal_DeterminesTotalPrice_Int()
    // {
    //   int loaf = 7;
    //   Bread newBread = new Bread(loaf);
    //   int numberOfLoafs = newBread.Loaf;
    //   int results = newBread.CalculateBreadTotal(numberOfLoafs);
    //   Assert.AreEqual(25, results);
    // }








  }
}