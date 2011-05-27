using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem24Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(2783915460, new Problem24().Solve());
    }
  }
}
