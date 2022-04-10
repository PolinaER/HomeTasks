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
    public class FictionEditionTests
    {
        [Test]
        public void ConstructorTest()
        {
            var comedy = CreateTestFictionEditoin();

            Assert.AreEqual("Божественная комедия", comedy.Name);
            Assert.AreEqual("Данте Алигьери", comedy.Authors);
            Assert.AreEqual(2019, comedy.YearPublication);
            Assert.AreEqual("АСТ Москва", comedy.PublishingHouse);
            Assert.AreEqual(9785171001803, comedy.InventoryNumber);
            Assert.AreEqual(380, comedy.Cost);
            Assert.AreEqual(EditionStatus.Home, comedy.Status); 
            Assert.AreEqual("итальянский", comedy.Language);
            Assert.AreEqual("комедия", comedy.Genre);
            Assert.AreEqual(FictionEditionType.Poetry, comedy.Type);
        }

        [Test]
        public void GetInfoTest()
        {
            var comedy = CreateTestFictionEditoin();

            var inf = comedy.GetInfo();

            Assert.AreEqual(1, inf.Length);
            Assert.AreEqual("Язык произведения: итальянский, жанр: комедия, вид: поэзия", inf[0]); 
            
        }
    
        public FictionEdition CreateTestFictionEditoin()
        {
            return new FictionEdition("Божественная комедия", "Данте Алигьери", 380, 2019, "АСТ Москва", 9785171001803, EditionStatus.Home, "комедия", "итальянский", FictionEditionType.Poetry);
        }
    }
}
