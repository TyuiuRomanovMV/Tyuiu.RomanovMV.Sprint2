
using Tyuiu.RomanovMV.Sprint2.Task6.V15.Lib;

namespace Tyuiu.RomanovMV.Sprint2.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("понедельник", ds.FindDayName(1));
            Assert.AreEqual("вторник", ds.FindDayName(2));
            Assert.AreEqual("среда", ds.FindDayName(3));
            Assert.AreEqual("четверг", ds.FindDayName(4));
            Assert.AreEqual("пятница", ds.FindDayName(5));
            Assert.AreEqual("суббота", ds.FindDayName(6));
            Assert.AreEqual("воскресенье", ds.FindDayName(0));

            Assert.Throws<ArgumentException>(() =>
            {
                ds.FindDayName(-1);
            });
            Assert.Throws<ArgumentException>(() =>
            {
                ds.FindDayName(366);
            });
        }
    }
}
