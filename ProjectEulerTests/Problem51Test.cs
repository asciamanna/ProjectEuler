using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem51Test {
    [Test]
    public void Solve() {

    }

    [Test]
    public void BuildDigitCountLookupTest() {
      var digitsCountLookup = Problem51.BuildDigitCountLookup(161617777);
      Assert.AreEqual(4, digitsCountLookup[7]);
      Assert.AreEqual(3, digitsCountLookup[1]);
      Assert.AreEqual(2, digitsCountLookup[6]);
    }
  }
}
