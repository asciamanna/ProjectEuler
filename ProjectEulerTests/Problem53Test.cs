using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem53Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(4075, new Problem53().Solve());
    }
  }
}
