﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem57Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(153, new Problem57().Solve());
    }
  }
}
