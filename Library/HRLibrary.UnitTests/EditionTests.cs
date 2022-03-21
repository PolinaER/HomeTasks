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
        }

        [Test]
        public void ToStringEdition_AuthorsNameInventoryName()
        {
            var comedy = CreateTestEdition();

            Assert.AreEqual("Данте Алигьери: Божественная комедия, инвентарный номер: 9785171001803", comedy.ToString());
        }

        Edition CreateTestEdition()
        {
            return new Edition("Божественная комедия", "Данте Алигьери", 2019, "АСТ Москва", 9785171001803);
        }
    }
}
