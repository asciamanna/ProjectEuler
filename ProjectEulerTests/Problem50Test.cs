using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
 public class Problem50Test {
    [Test]
    public void Below100() {
      Assert.AreEqual(41, new Problem50(100).Solve());
    }

    [Test]
    public void Below1000() {
      Assert.AreEqual(953, new Problem50(1000).Solve());
    }

    [Test]
    public void Solve() {
      Assert.AreEqual(997651, new Problem50().Solve());
    }
  }
}
