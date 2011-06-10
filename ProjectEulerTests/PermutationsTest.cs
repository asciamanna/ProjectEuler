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
      var permutations = Permutations<char>.Generate(new List<char> { 'a', 'b', 'c' });
      Assert.Contains(new List<char> { 'a', 'b', 'c' }, permutations);
      Assert.Contains(new List<char> { 'b', 'a', 'c' }, permutations);
      Assert.AreEqual(6, permutations.Count);
    }
  }
}
