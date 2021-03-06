﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler {
  [EulerProblem(29, "how many distinct terms are in the sequence generated by a^b for 2 ≤ a ≤ 100 and 2 ≤ b ≤ 100?")]
  public class Problem29 : Problem {
    int startingRange;
    int endingRange;

    public Problem29() : this(2, 100) { }

    public Problem29(int startingAandBRange, int endingAandBRange) {
      this.startingRange = startingAandBRange;
      this.endingRange = endingAandBRange;
    }
    public override long Solve() {
      var aRange = Enumerable.Range(startingRange, endingRange - startingRange + 1);
      var bRange = Enumerable.Range(startingRange, endingRange - startingRange + 1);
      var results = new List<BigInteger>();
      foreach (var a in aRange) {
        foreach (var b in bRange) {
          results.Add(new BigInteger(Math.Pow(a, b)));
        }
      }
      return results.Distinct().Count();
    }
  }
}
