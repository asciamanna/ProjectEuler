using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem59Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(107359, new Problem59().Solve());
    }
  }
}
