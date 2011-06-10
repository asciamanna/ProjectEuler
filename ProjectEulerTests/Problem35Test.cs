using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  class Problem35Test {
    [Test]
    public void Example() {
      Assert.AreEqual(13, new Problem35(100).Solve());
    }
  }
}
