﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests {
 [TestFixture]
 public class Problem55Test {
   [Test]
   public void Solve() {
     Assert.AreEqual(249, new Problem55().Solve());
   }
 }

}
