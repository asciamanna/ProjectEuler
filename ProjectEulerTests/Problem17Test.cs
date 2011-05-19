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
      //Assert.AreEqual(19, new Problem17(1, 5).Solve());
    }

    [Test]
    public void BuildNumberText_twenty_or_less() {
      Assert.AreEqual("twenty", new Problem17(1,1).BuildNumberText(20));
    }

    [Test]
    public void BuildNumberText_between_21_and_99() {
      Assert.AreEqual("ninety nine", new Problem17(1, 1).BuildNumberText(99));
    }

    [Test]
    public void BuildNumberText_between_100_and_999() {
      Assert.AreEqual("seven hundred and fifty eight", new Problem17(1, 1).BuildNumberText(758));
    }

    //TODO: Round down to work with tens and 100s
    //TODO: two digit ends in zero
    //TODO: three digit ends in zero
    //TODO: 1000
    //TODO: 0
    //TODO: negative
    //TODO: removes spaces and hyphens
  }
}
