using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem5Test {
    [Test]
    public void Example() {
      Assert.AreEqual(2520, new Problem5(1, 10).Solve());
    }

    [Test]
    public void Solve() {
      Assert.AreEqual(232792560, new Problem5(1, 20).Solve());
    }
  }
}
