using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem7Test {
    [Test]
    public void Example() {
      Assert.AreEqual(13, new Problem7(6).Solve());
    }

    [Test]
    public void Solve() {
      Assert.AreEqual(104743, new Problem7(10001).Solve());
    }
  }
}
