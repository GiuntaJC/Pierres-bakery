namespace Bakery.Models
{
  public class BakeryBread
  {
    public int GetBreadPrice(int breadAmount)
    {
      int totalBreadPrice = 0;
      while(breadAmount >= 2)
      {
        breadAmount -= 2;
        totalBreadPrice += 5;
      }
      if(breadAmount == 1)
      {
        totalBreadPrice += 5;
      }

      return totalBreadPrice;
    }
  }
}