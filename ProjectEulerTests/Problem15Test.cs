using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem15Test {
    [Test]
    public void Example() {
      Assert.AreEqual(6, new Problem15(2).Solve());
    }

    [Test]
    public void Solve() {
      Assert.AreEqual(137846528820, new Problem15(20).Solve());
    }
  }
}
