using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem17Test {
    [Test]
    public void Example() {
      Assert.AreEqual(19, new Problem17(1, 5).Solve());
    }
  }
}
