using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem60Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(26033, new Problem60().Solve());
    }
  }
}
