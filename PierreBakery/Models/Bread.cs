namespace PierreBakery.Models
{
  public class Bread : Dough
  {
    // private int _loaf;
    // public int Loaf
    // {
    //   get { return _loaf; }

    // }
    public Bread(int quantity)
    {
      Quantity = quantity;

    }

    public int CalculateBreadTotal(int numOfLoaf)
    {
      int totalPrice = 0;
      for (int i = 0; i <= numOfLoaf; i++)
      {
        if (i % 3 == 0)
        {
          totalPrice += 0;
        }
        else
        {
          totalPrice += 5;
        }
      }
      return totalPrice;
    }

    //implement caltotal method from dough class
    public override int CalTotal(int Quantity)
    {
      int totalPrice = 0;
      for (int i = 0; i <= Quantity; i++)
      {
        if (i % 3 == 0)
        {
          totalPrice += 0;
        }
        else
        {
          totalPrice += 5;
        }
      }
      return totalPrice;
    }


  }
}