using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem28Test {
    [Test]
    public void Example() {
      Assert.AreEqual(101, new Problem28(5).Solve());
    }

    [Test]
    public void Solve() {
      Assert.AreEqual(669171001, new Problem28().Solve());
    }
  }
}
