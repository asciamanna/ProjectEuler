using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem11Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(70600674, new Problem11().Solve());
    }
  }
}
