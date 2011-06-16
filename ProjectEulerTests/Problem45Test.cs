using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem45Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(1533776805, new Problem45().Solve());
    }

    [Test]
    public void GenerateTriangleNumber() {
      Assert.AreEqual(40755, new Problem45().GenerateTriangleNumber(285));
    }
  }
}
