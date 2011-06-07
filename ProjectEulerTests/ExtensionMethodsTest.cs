using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class ExtensionMethodsTest {
    [Test]
    public void IsPandigital() {
      Assert.IsTrue(123456789.IsPandigital());
      Assert.IsFalse(70123.IsPandigital());
      Assert.IsFalse(48436.IsPandigital());
    }
  }
}
