using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem48Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(9110846700, new Problem48().Solve());
    }
  }
}
