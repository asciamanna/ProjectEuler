using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem23Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(4179871, new Problem23().Solve());
    }
  }
}
