using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem9Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(31875000, new Problem9().Solve());
    }
  }
}
