using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;
using System.Numerics;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem34Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(40730, new Problem34().Solve());
    }

    [Test]
    public void NumberEqualsFactorialOfDigits() {
      Assert.IsTrue(new Problem34().NumberEqualsFactorialOfDigits(145));
      Assert.IsFalse(new Problem34().NumberEqualsFactorialOfDigits(555));
    }
  }

}
