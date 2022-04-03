using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using NUnit.Framework;

namespace HRLibrary.UnitTests
{
    [TestFixture]
    public class PeriodicalEditionTests
    {
        [Test]
        public void ConstructorTest()
        {
            var life = CreateTestPeriodicalEdition();

            Assert.AreEqual("ABN Life", life.Name);
            Assert.AreEqual("Juvia Mel", life.Authors);
            Assert.AreEqual(200, life.Cost);
            Assert.AreEqual(1997, life.YearPublication);
            Assert.AreEqual("SpainFox", life.PublishingHouse);
            Assert.AreEqual(12345678919, life.InventoryNumber);
            Assert.AreEqual(EditionStatus.Home, life.Status);
            Assert.AreEqual(3, life.RealisePeriod);
            Assert.AreEqual(PeriodicalEditionType.Magazine, life.Type);
        }

        [Test]
        public void GetInfoTest()
        {
            var life = CreateTestPeriodicalEdition();

            var inf = life.GetInfo();

            Assert.AreEqual(1, inf.Length);
            Assert.AreEqual("Вид периодики: журнал, период выхода: 3", inf[0]);
        }

        public PeriodicalEdition CreateTestPeriodicalEdition()
        {
            return new PeriodicalEdition("ABN Life", "Juvia Mel", 200, 1997, "SpainFox", 12345678919, EditionStatus.Home, 3, PeriodicalEditionType.Magazine);
        }
    }
}
