using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.TestTools
{
  [TestClass]
  public class BakeryBreadTests
  {
    [TestMethod]
    public void BakeryBread_GetSinglePrice()
    {
      BakeryBread testBakeryBread = new BakeryBread();
      Assert.AreEqual(5, testBakeryBread.GetBreadPrice(1));
    }

    [TestMethod]
    public void BakeryBread_GetTriplePrice()
    {
      BakeryBread testBakeryBread = new BakeryBread();
      Assert.AreEqual(10, testBakeryBread.GetBreadPrice(3));
    }
  }
}