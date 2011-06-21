using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem49Test {
    [Test]
    public void Solve() {

    }

    [Test]
    public void FindSequence() {
      // 1487, 4817, 8147
      var sequence = new Problem49().FindSequence(new List<long> { 1487, 4817, 8147 });
      Assert.AreEqual(3, sequence.Count);

      var sequence2 = new Problem49().FindSequence(new List<long> { 1487, 7841, 4817, 7418, 8147 });
      Assert.AreEqual(3, sequence.Count);
    }
  }
}
