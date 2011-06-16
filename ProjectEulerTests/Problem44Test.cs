using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem44Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(5482660, new Problem44().Solve());
    }
  }
}
