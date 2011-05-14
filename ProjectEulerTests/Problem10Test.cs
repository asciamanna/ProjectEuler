using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem10Test {
    [Test]
    public void Example() {
      Assert.AreEqual(17, new Problem10(10).Solve());
    }

    [Test]
    public void Solve() {
      Assert.AreEqual(142913828922, new Problem10(2000000).Solve());
    }
  }
}
