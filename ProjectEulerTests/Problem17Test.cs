using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem17Test {
    [Test]
    public void Example() {
      Assert.AreEqual(19, new Problem17(1, 5).Solve());
    }

    [Test]
    public void Solve() {
      Assert.AreEqual(21124, new Problem17(1, 1000).Solve());
    }

    [Test]
    public void BuildNumberText_twenty_or_less() {
      Assert.AreEqual("twenty", Problem17.BuildNumberText(20));
    }

    [Test]
    public void BuildNumberText_two_digits_not_in_dictionary() {
      Assert.AreEqual("sixty", Problem17.BuildNumberText(60));
    }

    [Test]
    public void BuildNumberText_eighty() {
      Assert.AreEqual("eighty", Problem17.BuildNumberText(80));
    }

    [Test]
    public void BuildNumberText_between_21_and_99() {
      Assert.AreEqual("ninety nine", Problem17.BuildNumberText(99));
    }

    [Test]
    public void BuildNumberText_between_100_and_999() {
      Assert.AreEqual("seven hundred and fifty eight", Problem17.BuildNumberText(758));
      Assert.AreEqual("three hundred and seventy six", Problem17.BuildNumberText(376));
    }

    [Test]
    public void BuildNumberText_even_hundred_numbers() {
      Assert.AreEqual("eight hundred", Problem17.BuildNumberText(800));
    }
  }
}
