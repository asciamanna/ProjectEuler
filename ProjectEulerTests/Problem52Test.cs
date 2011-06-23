using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem52Test {
    [Test]
    public void Solve() {
    }

    [Test]
    public void ContainsSameDigitsAsNumberTest() {
      Assert.IsTrue(new Problem52().ContainsSameDigitsAsNumber(52, 25));
      Assert.IsFalse(new Problem52().ContainsSameDigitsAsNumber(10, 55));
    }
  }
}
