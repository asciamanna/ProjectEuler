using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem13Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(5537376230, new Problem13().Solve());
    }
  }
}
