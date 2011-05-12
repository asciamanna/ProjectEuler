using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  class Problem6Test {
    [Test]
    public void Example() {
      Assert.AreEqual(2640, new Problem6(10).Solve());
    }
   
    [Test]
    public void Solve() {
      Assert.AreEqual(25164150, new Problem6(100).Solve());
    }
  }
}
