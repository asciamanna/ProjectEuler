using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class PandigitalsTest {
    [Test]
    public void Generate() {
      var pandigitals1 = Pandigitals.Generate(1);
      Assert.Contains(1, pandigitals1.ToList());
      var pandgitals2 = Pandigitals.Generate(2);
      Assert.Contains(12, pandgitals2.ToList());
      Assert.Contains(21, pandgitals2.ToList());

      var pandigitals9 = Pandigitals.Generate(9);
      Assert.AreEqual(987654321, pandigitals9.Max());

    }
  }
}
