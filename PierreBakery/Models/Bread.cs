

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

    public int CalculateBreadTotal(int numOfLoaf)
    {
      int totalPrice = 0;
      for (int i = 0; i <= numOfLoaf; i++)
      {
        if (i % 3 == 0)
        {
          totalPrice+=0;
        }
        else
        {
          totalPrice+=5; 
        }
      }
      return totalPrice;
    }

    
  }
}