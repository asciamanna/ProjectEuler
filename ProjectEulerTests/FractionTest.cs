using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class FractionTest {
    [Test]
    public void Reduce() {
      Assert.AreEqual(new Fraction(1, 8), new Fraction(3, 24).Reduce());
    }

    [Test]
    public void CanBeReducedTo() {
      Assert.IsTrue(new Fraction(49, 98).CanBeReducedTo(new Fraction(4, 8)));
    }
  }
}
