using System;

public class ShoppingCart
{
  public int orderPrice {get; set;}
  public int pastryCount {get; set;}
  public int breadCount {get; set;}

  public ShoppingCart(int price, int pastries, int bread)
  {
    orderPrice = price;
    pastryCount = pastries;
    breadCount = bread;
  }
}
public class Program
{
	public static void Main()
	{
		
	}
}