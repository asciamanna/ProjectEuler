using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;
using System.Numerics;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem26Test {
    [Test]
    public void Example() {
      Assert.AreEqual(7, new Problem26(10).Solve());
    }

    [Test]
    public void Solve() {
      Assert.AreEqual(983, new Problem26(1000).Solve());
    }

    [Test]
    public void FindRecurringCycleLength() {
      Assert.AreEqual(1, new Problem26(10).FindRecurringCycleLength(3));
      Assert.AreEqual(6, new Problem26(10).FindRecurringCycleLength(7));
      Assert.AreEqual(999, new Problem26(2000).FindRecurringCycleLength(1999));
    }
  }
}
