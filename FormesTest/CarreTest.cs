using NUnit.Framework;

namespace Formes
{
    [TestFixture]
    public class CarreTest
    {

        [Test]
        public void TestSurface()
        {
            Carre c = new Carre(1.0, 1.0, 3.0);

            Assert.AreEqual(9.0, c.Surface());
        }

        [Test]
        public void TestContientPoint()
        {
            Carre c = new Carre(1.0, 1.0, 3.0);

            Assert.AreEqual(true, c.ContientPoint(1.5, 1.5));
        }

    }
}