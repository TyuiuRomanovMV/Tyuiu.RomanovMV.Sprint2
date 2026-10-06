
using Tyuiu.RomanovMV.Sprint2.Task5.V5.Lib;

namespace Tyuiu.RomanovMV.Sprint2.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Шестрёрка", ds.FindCardValue(6));
            Assert.AreEqual("Семёрка", ds.FindCardValue(7));
            Assert.AreEqual("Восьмёрка", ds.FindCardValue(8));
            Assert.AreEqual("Девятка", ds.FindCardValue(9));
            Assert.AreEqual("Десятка", ds.FindCardValue(10));
            Assert.AreEqual("Валет", ds.FindCardValue(11));
            Assert.AreEqual("Дама", ds.FindCardValue(12));
            Assert.AreEqual("Король", ds.FindCardValue(13));
            Assert.AreEqual("Туз", ds.FindCardValue(14));

            Assert.Throws<ArgumentException>(() =>
            {
                ds.FindCardValue(5);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                ds.FindCardValue(15);
            });
        } 
    }
}
