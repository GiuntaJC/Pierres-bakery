using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.TestTools
{
  public class BakeryShoppingCartTests
  {
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      ShoppingCart newOrder = new ShoppingCart(3, 4, 5);

      int result = 3;

      Assert.AreEqual(newOrder.OrderPrice, result);
    }
  }
}