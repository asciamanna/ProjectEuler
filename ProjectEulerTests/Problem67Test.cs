using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem67Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(7273, new Problem67().Solve());
    }
  }
}
