using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem37Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(748317, new Problem37().Solve());
    }
  }
}
