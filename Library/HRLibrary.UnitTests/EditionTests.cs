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
    public class EditionTests
    {
        [Test]
        public void ConstructorTest()
        {
            var comedy = CreateTestEdition();

            Assert.AreEqual("Божественная комедия", comedy.Name);
            Assert.AreEqual("Данте Алигьери", comedy.Authors);
            Assert.AreEqual(2019, comedy.YearPublication);
            Assert.AreEqual("АСТ Москва", comedy.PublishingHouse);
            Assert.AreEqual(9785171001803, comedy.InventoryNumber);
            Assert.AreEqual(380, comedy.Cost);
            Assert.AreEqual(EditionStatus.Home, comedy.Status);
        }

        [Test]
        public void ToStringEdition_AuthorsNameInventoryName()
        {
            var comedy = CreateTestEdition();

            Assert.AreEqual("Данте Алигьери: Божественная комедия, инвентарный номер: 9785171001803", comedy.ToString());
        }

        [Test]
        public void GetInfoTest()
        {
            var comedy = CreateTestEdition();

            var info = comedy.GetInfo();

            Assert.AreEqual(3, info.Length);
            Assert.AreEqual("Данте Алигьери: Божественная комедия, инвентарный номер: 9785171001803", info[0]);
            Assert.AreEqual("Год публикации: АСТ Москва, дата публикации: 2019", info[1]);
            Assert.AreEqual("Стоимость: 380. Статус издания: выдана на дом", info[2]);
        }


        Edition CreateTestEdition()
        {
            return new Edition("Божественная комедия", "Данте Алигьери", 380, 2019, "АСТ Москва", 9785171001803, EditionStatus.Home);
        }
    }
}
