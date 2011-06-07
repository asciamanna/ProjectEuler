using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem32Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(45228, new Problem32().Solve());
    }
  }
}
