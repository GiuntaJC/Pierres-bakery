namespace Bakery.Models
{
  public class BakeryBread
  {
    public int BreadPrice { get; set; }
    public int BreadAmount { get; set; }
    public int GetBreadPrice(int breadAmount)
    {
      BreadAmount = breadAmount;
      BreadPrice = 0;
      
      while(BreadAmount >= 3)
      {
        BreadAmount -= 3;
        BreadPrice += 10;
      }
      if(BreadAmount == 1)
      {
        BreadPrice += 5;
      }

      return BreadPrice;
    }
  }
}