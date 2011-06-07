using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem31Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(73682, new Problem31().Solve());
    }
  }
}
