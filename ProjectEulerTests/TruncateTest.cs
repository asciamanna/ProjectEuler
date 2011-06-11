using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class TruncateTest {
    [Test]
    public void Truncate_Left_To_Right() {
      var truncate = new Truncate(234, TruncateMethod.LeftToRight);
      Assert.IsTrue(truncate.CanTruncate());
      Assert.AreEqual(34, truncate.NextValue());
      Assert.IsTrue(truncate.CanTruncate());
      Assert.AreEqual(4, truncate.NextValue());
      Assert.IsFalse(truncate.CanTruncate());
      Assert.AreEqual(4, truncate.CurrentValue());
    }

    [Test]
    public void Truncate_Right_To_Left() {
      var truncate = new Truncate(345, TruncateMethod.RightToLeft);
      Assert.IsTrue(truncate.CanTruncate());
      Assert.AreEqual(34, truncate.NextValue());
      Assert.IsTrue(truncate.CanTruncate());
      Assert.AreEqual(3, truncate.NextValue());
      Assert.IsFalse(truncate.CanTruncate());
      Assert.AreEqual(3, truncate.CurrentValue());
    }
  }
}
