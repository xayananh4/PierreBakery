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

  }
}