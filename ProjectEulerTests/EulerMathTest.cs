using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;
using System.Numerics;

namespace ProjectEulerTests {
  [TestFixture]
  public class EulerMathTest {
    [Test]
    public void Factorial10() {
      Assert.AreEqual(new BigInteger(3628800), EulerMath.Factorial(10));
    }

    [Test]
    public void Factorial4() {
      Assert.AreEqual(new BigInteger(24), EulerMath.Factorial(4));
    }

    [Test]
    public void GreatestCommonFactor() {
      Assert.AreEqual(8, EulerMath.GreatestCommonFactor(8, 16));
      Assert.AreEqual(1, EulerMath.GreatestCommonFactor(7, 51));
    }
  }
}
