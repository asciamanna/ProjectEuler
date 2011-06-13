using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem40Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(210, new Problem40().Solve());
    }
  }
}
