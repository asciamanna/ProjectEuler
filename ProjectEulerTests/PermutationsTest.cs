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
    public void Generate() {
      var permutations = Permutations.Generate(new List<char> { 'a', 'b', 'c' });
      Assert.Contains(new List<char> { 'a', 'b', 'c' }, permutations);
      Assert.Contains(new List<char> { 'b', 'a', 'c' }, permutations);
      Assert.AreEqual(6, permutations.Count);
    }

    [Test]
    public void GenerateForNumbers() {
      var permutations = Permutations.GenerateForNumbers(123);
      Assert.AreEqual(6, permutations.Count);
    }

    [Test]
    public void GenerateForNumbers_OneNumber() {
      Assert.AreEqual(1, Permutations.GenerateForNumbers(1).Count);
    }

    [Test]
    public void Rotations() {
      var rotations = Permutations.GenerateNumberRotations(197);
      Assert.AreEqual(3, rotations.Count);
    }
  }
}
