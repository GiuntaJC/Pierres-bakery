using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.TestTools
{
  [TestClass]
  public class BakeryShoppingCartTests
  {
    [TestMethod]
    public void ShoppingCart_AutoImplementedPropertiesCorrectlyAssign_OrderPrice()
    {
      ShoppingCart newOrder = new ShoppingCart(3, 4, 5);

      int result = 3;

      Assert.AreEqual(newOrder.OrderPrice, result);
    }

    [TestMethod]
    public void ShoppingCart_AutoImplementedPropertiesCorrectlyAssign_PastryCount()
    {
      ShoppingCart newOrder = new ShoppingCart(3, 4, 5);

      int result = 4;

      Assert.AreEqual(newOrder.PastryCount, result);
    }

    [TestMethod]
    public void ShoppingCart_AutoImplementedPropertiesCorrectlyAssign_BreadCount()
    {
      ShoppingCart newOrder = new ShoppingCart(3, 4, 5);

      int result = 5;

      Assert.AreEqual(newOrder.BreadCount, result);
    }
  }
}