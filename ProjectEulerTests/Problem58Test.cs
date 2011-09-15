using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem58Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(26241, new Problem58().Solve());
    }
  }
}
