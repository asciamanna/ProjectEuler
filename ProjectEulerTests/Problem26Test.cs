using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem26Test {
    [Test]
    public void Example() {
      Assert.AreEqual(7, new Problem26(10).Solve());
    }

    [Test]
    public void Solve() {
      //Assert.AreEqual(
    }

    [Test]
    public void FindRecurringCycleLength() {
      Assert.AreEqual(3, Problem26.FindRecurringCycleLength(0.123123123m));
      Assert.AreEqual(3, Problem26.FindRecurringCycleLength(0.89123123123m));
    }
  }
}
