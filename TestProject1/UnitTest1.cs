using InversionApp;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IBasket basket = new MemoryBasket();
            //IBasket basket = new LoggingBasket(new MemoryBasket());
            Market market = new Market(basket);
            market.Add("item1");
            market.Add("item2");
            Assert.AreEqual(2, market.Items.Count);

            market.AddItemToBasket(market.Items[0]);
            Assert.AreEqual(1, market.GetBasketItems().Count);
        }
    }
}