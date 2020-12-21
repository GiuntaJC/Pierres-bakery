using System;
using Bakery.Models;

public class Program
{
	public static void Main()
	{
    BakeryBread breadOrder = new BakeryBread();
    BakeryPastry pastryOrder = new BakeryPastry();
    ShoppingCart order = new ShoppingCart(0, 0, 0);

		Console.WriteLine("Welcome to Pierre's Bakery! We have 2 special deals for you today: Bread is buy 2, get 1 free, and pastries are 3 for $5!");
    Console.WriteLine("Our regular prices are 1 loaf of bread is $5, and pastries are $2 each.");
    Console.WriteLine("Now, what can I get for you? Make sure you include any free loaves in your order!");

    order.BreadCount = Program.checkInput("Bread");
    order.PastryCount = Program.checkInput("Pastries");
    order.OrderPrice = breadOrder.GetBreadPrice(order.BreadCount) + pastryOrder.GetPastryPrice(order.PastryCount);

    Console.WriteLine($"Your total price for {order.BreadCount} loaves of bread, and {order.PastryCount} pastries is:");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"${order.OrderPrice}");
    Console.ResetColor();
  }

  public static int checkInput(string orderStep)
  {
    bool validInput = false;
    int userInput = 0;
    while(!validInput)
    {
      Console.WriteLine($"{orderStep}: ");
      if(int.TryParse(Console.ReadLine(), out userInput))
      {
        validInput = true;
      }
      else
      {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Make sure you only enter integers");
      Console.ResetColor();
      }
    }
    return userInput;
  }
}