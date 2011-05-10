using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem3Test {
    [Test]
    public void Example() {
      Assert.AreEqual(29, new Problem3(13195).Solve());
    }

    [Test]
    public void Solve() {
      Assert.AreEqual(6857, new Problem3(600851475143).Solve());
    }
  }
}
