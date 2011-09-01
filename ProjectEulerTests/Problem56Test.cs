using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  class Problem56Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(972, new Problem56().Solve());
    }
  }
}
