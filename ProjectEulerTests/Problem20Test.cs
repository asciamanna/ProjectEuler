using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem20Test {
    [Test]
    public void Example() {
      Assert.AreEqual(27, new Problem20(10).Solve());
    }
    [Test]
    public void Solve() {
      Assert.AreEqual(648, new Problem20(100).Solve());
    }
  }
}
