using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem52Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(142857, new Problem52().Solve());
    }

    [Test]
    public void ContainsSameDigitsTest() {
      Assert.IsTrue(new Problem52().ContainsSameDigits(52, 25));
      Assert.IsFalse(new Problem52().ContainsSameDigits(10, 55));
    }
  }
}
