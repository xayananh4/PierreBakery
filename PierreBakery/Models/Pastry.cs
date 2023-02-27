namespace PierreBakery.Models
{
  public class Pastry : Dough
  {
    public Pastry(int quantity)
    {
      Quantity = quantity;
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
