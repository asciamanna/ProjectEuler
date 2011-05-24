using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem21Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(31626, new Problem21().Solve());
    }
  }
}
