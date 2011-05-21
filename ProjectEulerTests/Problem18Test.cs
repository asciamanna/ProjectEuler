using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem18Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(1074, new Problem18().Solve());
    }
  }
}
