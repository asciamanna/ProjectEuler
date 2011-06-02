using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem29Test {
    [Test]
    public void Example() {
      Assert.AreEqual(15, new Problem29(2, 5).Solve());
    }

    [Test]
    public void Solve() {
      Assert.AreEqual(9183, new Problem29().Solve());
    }
  }
}
