using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class FactorsTest {
    [Test]
    public void CalculateProperDivisors() {
      var expectedDivisors = new List<long> { 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110 };
      var properDivisors = Factors.CalculateProperDivisors(220);
      CollectionAssert.AreEqual(expectedDivisors, properDivisors);
    }

    [Test]
    public void CalculateDistinctPrimeFactors() {
      Assert.AreEqual(2, Factors.CalculateDistinctPrimeFactors(20).Count);
    }
  }
}
