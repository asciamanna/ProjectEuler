﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem16Test {
    [Test]
    public void Example() {
      Assert.AreEqual(26, new Problem16(2, 15).Solve());
    }
    [Test]
    public void Solve() {
      Assert.AreEqual(1366, new Problem16(2, 1000).Solve());
    }
  }
}
