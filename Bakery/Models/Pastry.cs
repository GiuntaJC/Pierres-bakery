namespace Bakery.Models
{
  public class BakeryPastry
  {
    public int PastryPrice { get; set; }
    public int PastryAmount { get; set; }

    public int GetPastryPrice(int pastryAmount)
    {
      PastryAmount = pastryAmount;
      PastryPrice = 0;

      while(PastryAmount >= 3)
      {
        PastryAmount -= 3;
        PastryPrice += 5;
      }
      while(PastryAmount >= 1)
      {
        PastryAmount-= 1;
        PastryPrice += 2;
      }

      return PastryPrice;
    }
  }
}