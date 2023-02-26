

namespace PierreBakery.Models
{
  public abstract class Bread
  {
    private int _loaf;
    public int Loaf
    {
      get { return _loaf; }

    }
    public Bread(int loaf)
    {
      _loaf = loaf;
      
    }

    public int CalculateTotal(int numOfLoaf)
    {
      int totalPrice = 0;
      int noChargeLoaf = 0;
      for (int i = 0; i <= numOfLoaf; i++)
      {
        if (i % 3 == 0)
        {
          totalPrice = totalPrice + noChargeLoaf;
        }
        else
        {
          totalPrice = totalPrice + 5;
        }
      }
      return totalPrice;
    }
  }
}