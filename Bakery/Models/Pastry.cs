namespace Bakery.Models
{
  public class BakeryPastry
  {
    public int GetPastryPrice(int pastryAmount)
    {
      int totalPastryPrice = 0;
      while(pastryAmount >= 3)
      {
        pastryAmount -= 3;
        totalPastryPrice += 5;
      }
      while(pastryAmount >= 1)
      {
        pastryAmount-= 1;
        totalPastryPrice += 2;
      }

      return totalPastryPrice;
    }
  }
}