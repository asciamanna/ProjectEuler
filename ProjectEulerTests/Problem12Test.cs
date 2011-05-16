using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem12Test {
    [Test]
    public void Example() {
      Assert.AreEqual(28, new Problem12(5).Solve());
    }

    [Test]
    public void Solve() { 
    //Assert.AreEqual(
    }

    [Test]
    public void CalculateNthTriangleNumber() {
      Assert.AreEqual(28, Problem12.CalculateNthTriangleNumber(7));
    }
  }
}
