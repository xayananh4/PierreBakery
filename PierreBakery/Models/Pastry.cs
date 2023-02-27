namespace PierreBakery.Models
{
  public class Pastry : Dough
  {
    // private int _pastry;
    // public int Pastries
    // {
    //   get { return _pastry; }
    // }

    public Pastry(int quantity)
    {
      Quantity = quantity;
    }

    public int CalculatePastryTotal(int numOfPastries)
    {
      int totalPrice = 0;
      int noChargeLoaf = 0;
      for (int i = 0; i <= numOfPastries; i++)
      {
        if (i % 4 == 0)
        {
          totalPrice = totalPrice + noChargeLoaf;
        }
        else
        {
          totalPrice = totalPrice + 2;
        }
      }
      return totalPrice;
    }

    public override int CalTotal(int Quantity)
    {
      int totalPrice = 0;
      for (int i = 0; i <= Quantity; i++)
      {
        if (i % 4 == 0)
        {
          totalPrice+=0;
        }
        else
        {
          totalPrice+=2;
        }
      }
      return totalPrice;
    }
  }
}
