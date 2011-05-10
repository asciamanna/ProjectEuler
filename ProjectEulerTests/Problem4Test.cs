using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem4Test {
    [Test]
    public void Example() {
      Assert.AreEqual(9009, new Problem4(2).Solve());
    }

    [Test]
    public void Solve() {
      Assert.AreEqual(906609, new Problem4(3).Solve());
    }
  }
}
