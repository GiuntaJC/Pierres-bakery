namespace Bakery.Models
{
  public class ShoppingCart
  {
    public int OrderPrice { get; set; }
    public int PastryCount { get; set; }
    public int BreadCount { get; set; }

    public ShoppingCart(int price, int pastries, int bread)
    {
      OrderPrice = price;
      PastryCount = pastries;
      BreadCount = bread;
    }
  }
}