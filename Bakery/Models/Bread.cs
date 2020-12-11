namespace Bakery.Models
{
  public class BakeryBread
  {
    public int GetBreadPrice(int breadAmount)
    {
      int totalBreadPrice = 0;
      while(breadAmount >= 3)
      {
        breadAmount -= 3;
        totalBreadPrice += 10;
      }
      if(breadAmount == 1)
      {
        totalBreadPrice += 5;
      }

      return totalBreadPrice;
    }
  }
}