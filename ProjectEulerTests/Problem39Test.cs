using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem39Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(840, new Problem39().Solve());
    }
  }
}
