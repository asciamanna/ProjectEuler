using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem25Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(4782, new Problem25(1000).Solve());
    }
  }
}
