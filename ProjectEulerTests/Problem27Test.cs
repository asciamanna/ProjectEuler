using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
 public class Problem27Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(-59231, new Problem27().Solve());
    }
  }
}
