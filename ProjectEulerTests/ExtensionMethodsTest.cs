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

    public void IsZeroToNPandigital() {
      Assert.IsTrue(10234.IsZeroToNPandigital());
      Assert.IsFalse(1234.IsZeroToNPandigital());
    }

    [Test]
    public void ToBinary() {
      Assert.AreEqual("1001001001", 585.ToBinary());
    }

    [Test]
    public void IsPalindromic() {
      Assert.IsTrue(8778778.IsPalindromic());
      Assert.IsFalse(123987.IsPalindromic());
    }

    [Test]
    public void IsPentagonal() {
      Assert.IsTrue(((long)145).IsPentagonal());
      Assert.IsFalse(((long)4).IsPentagonal());
      Assert.IsTrue(((long)40755).IsPentagonal());
      Assert.IsTrue(((long)1533776805).IsPentagonal());
    }

    [Test]
    public void IsHexagonal() {
      Assert.IsTrue(((long)45).IsHexagonal());
      Assert.IsFalse(((long)32).IsHexagonal());
      Assert.IsTrue(((long)40755).IsHexagonal());
      Assert.IsTrue(((long)1533776805).IsHexagonal());
    }

    [Test]
    public void IsTriangle() {
      Assert.IsTrue(((long)1).IsTriangle());
      Assert.IsTrue(((long)3).IsTriangle());
      Assert.IsTrue(((long)6).IsTriangle());
      Assert.IsTrue(((long)15).IsTriangle());
      Assert.IsTrue(((long)21).IsTriangle());
      Assert.IsFalse(((long)11).IsTriangle());
    }

    [Test]
    public void IsSquare() {
      Assert.IsTrue(((long)1).IsSquare());
      Assert.IsTrue(((long)4).IsSquare());
      Assert.IsTrue(((long)9).IsSquare());
      Assert.IsTrue(((long)16).IsSquare());
      Assert.IsTrue(((long)49).IsSquare());
      Assert.IsFalse(((long)55).IsSquare());
    }
  }
}
