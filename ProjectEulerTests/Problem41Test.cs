using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem41Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(7652413, new Problem41().Solve());
    }
  }
}
