using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem43Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(16695334890, new Problem43().Solve());
    }
  }
}
