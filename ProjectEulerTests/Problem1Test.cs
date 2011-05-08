using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem1Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(233168, new Problem1(1000).Solve());
    }
  }
}
