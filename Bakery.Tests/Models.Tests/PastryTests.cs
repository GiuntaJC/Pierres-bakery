using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.TestTools
{
  [TestClass]
  public class BakeryPastryTests
  {
    [TestMethod]
    public void BakeryPastry_GetSinglePrice()
    {
      BakeryPastry testBakeryPastry = new BakeryPastry();
      Assert.AreEqual(2, testBakeryPastry.GetPastryPrice(1));
    }

    [TestMethod]
    public void BakeryPastry_GetTriplePrice()
    {
      BakeryPastry testBakeryPastry = new BakeryPastry();
      Assert.AreEqual(5, testBakeryPastry.GetPastryPrice(3));
    }
  }
}