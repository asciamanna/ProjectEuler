using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
 [TestFixture]
  public class Problem30Test {
   [Test]
   public void Solve() {
     Assert.AreEqual(443839, new Problem30(5).Solve());
   }

   [Test]
   public void Example() {
     Assert.AreEqual(19316, new Problem30(4).Solve());
   }
  }
}
