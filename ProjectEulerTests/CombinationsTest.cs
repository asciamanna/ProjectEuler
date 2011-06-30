using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;
using System.Numerics;

namespace ProjectEulerTests {
  [TestFixture]
  public class CombinationsTest {
    [Test]
    public void NChooseR() {
      Assert.AreEqual(Combinations.NChooseR(5, 3), new BigInteger(10));
    }
  }
}
