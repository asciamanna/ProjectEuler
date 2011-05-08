using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  class Problem2Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(4613732, new Problem2().Solve());
    }
  }
}
