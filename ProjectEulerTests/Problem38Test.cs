﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
  [TestFixture]
  public class Problem38Test {
    [Test]
    public void Solve() {
      Assert.AreEqual(932718654, new Problem38().Solve());
    }
  }
}
