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
    public class ScienceEditionTests
    {
        [Test]
        public void ConstructorTest()
        {
            var way = CreateTestScienseEdition();

            Assert.AreEqual("Way of Paradox", way.Name);
            Assert.AreEqual("M.Clark", way.Authors);
            Assert.AreEqual(1200, way.Cost);
            Assert.AreEqual(2021, way.YearPublication);
            Assert.AreEqual("ScienceNear", way.PublishingHouse);
            Assert.AreEqual(86349237642, way.InventoryNumber);
            Assert.AreEqual(EditionStatus.Home, way.Status);
            Assert.AreEqual("logic", way.Science);
            Assert.AreEqual("Antinomy, self-referense and isolubilia", way.Annotation);
        }

        [Test]
        public void GetInfoTest()
        {
            var way = CreateTestScienseEdition();

            var inf = way.GetInfo();

            Assert.AreEqual(2, inf.Length);
            Assert.AreEqual("Аннотация: Antinomy, self-referense and isolubilia", inf[0]);
            Assert.AreEqual("Научная область: logic", inf[1]);
        }

        public ScienceEdition CreateTestScienseEdition()
        {
            return new ScienceEdition("Way of Paradox","M.Clark", 1200, 2021,"ScienceNear", 86349237642, EditionStatus.Home, "logic", "Antinomy, self-referense and isolubilia");
        }
    }
}
