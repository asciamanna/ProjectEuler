using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem42Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(162, new Problem42().Solve());
    }
  }
}
