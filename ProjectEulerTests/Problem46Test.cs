﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem46Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(5777, new Problem46().Solve());
    }
  }
}
