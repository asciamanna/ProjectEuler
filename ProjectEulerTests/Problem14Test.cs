using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem14Test {
    [Test]
    public void CalculateSequence() {
      Assert.AreEqual(10, Problem14.CalculateSequence(13).Count);
    }

    [Test]
    public void Solve() {
      Assert.AreEqual(837799, new Problem14(1000000).Solve());
    }
  }
}
