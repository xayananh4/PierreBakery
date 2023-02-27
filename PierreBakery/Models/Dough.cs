namespace PierreBakery.Models
{
  public abstract class Dough
  {
   public int Quantity { get; set; }
   public abstract int CalTotal(int Quantity);
    // public Dough()
    // {

    // }

  }
}