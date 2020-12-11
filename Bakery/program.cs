using System;
using Bakery.Models;

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
    BakeryBread breadOrder = new BakeryBread();
    BakeryPastry pastryOrder = new BakeryPastry();
    ShoppingCart order = new ShoppingCart(0, 0, 0);
    bool validInput = false;

		Console.WriteLine("Welcome to Pierre's Bakery! We have 2 special deals for you today: Bread is buy 2, get 1 free, and pastries are 3 for $5!");
    Console.WriteLine("Our regular prices are 1 loaf of bread is $5, and pastries are $2 each.");
    Console.WriteLine("Now, what can I get for you? Make sure you include any free loaves in your order!");
    
    while(!validInput)
    {
      Console.WriteLine("Bread:");
      if(int.TryParse(Console.ReadLine(), out int userInput))
      {
        order.breadCount = userInput;
        validInput = true;
      }
      else
      {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Make sure you only enter integers");
      Console.ResetColor();
      }
    }

    validInput = false;
    while(!validInput)
    {
      Console.WriteLine("Pastries:");
      if(int.TryParse(Console.ReadLine(), out int userInput))
      {
        order.pastryCount = userInput;
        validInput = true;
      }
      else
      {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Make sure you only enter integers");
      Console.ResetColor();
      }
    }
    order.orderPrice = breadOrder.GetBreadPrice(order.breadCount) + pastryOrder.GetPastryPrice(order.pastryCount);

    Console.WriteLine($"Your total price for {order.breadCount} loaves of bread, and {order.pastryCount} pastries is:");
    Console.WriteLine($"${order.orderPrice}");
  }
}