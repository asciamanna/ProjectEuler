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

    [Test]
    public void ToBinary() {
      Assert.AreEqual(1001001001, 585.ToBinary());
    }

    [Test]
    public void IsPalindromic() {
      Assert.IsTrue(8778778.IsPalindromic());
      Assert.IsFalse(123987.IsPalindromic());
    }
  }
}
