namespace PierreBakery.Models
{
  public class Pastry
  {
    private int _pastry;
    public int Pastries
    {
      get { return _pastry; }

    }

    public Pastry(int pastry)
    {
      _pastry = pastry;

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



  }
}