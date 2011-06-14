using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class PermutationsTest {
    [Test]
    public void Generate_Numbers_3digits() {
      var permutations = Permutations.Generate(123);
      Assert.AreEqual(6, permutations.Count);
    }

    [Test]
    public void Generate_Numbers_4digits() {
      var permutations = Permutations.Generate(1234);
      Assert.AreEqual(24, permutations.Count);
    }

    [Test]
    public void Rotations() {
      var rotations = Permutations.GenerateNumberRotations(197);
      Assert.AreEqual(3, rotations.Count);
    }
  }
}
