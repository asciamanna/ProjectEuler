using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  public class PrimeGeneratorTest {
    [Test]
    public void CalculatePrimes() {
      var expectedPrimes = new List<long> {
        2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97
      };
      var primes = PrimeGenerator.CalculatePrimesBelow(100);
      Assert.AreEqual(expectedPrimes.Count, primes.Count());
      Assert.AreEqual(expectedPrimes.Count, expectedPrimes.Intersect(primes).Count());
    }

    [Test]
    public void CalculateNthPrime() {
      Assert.AreEqual(97, PrimeGenerator.CalculateNthPrime(25));
    }
  }
}
