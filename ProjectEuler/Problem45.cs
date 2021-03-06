﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler {
  [EulerProblem(45, "After 40755, what is the next triangle number that is also pentagonal and hexagonal?")]
  public class Problem45 : Problem {
    //start at T286 since T285 was first triangle number that is also hexagonal and pentagonal.
    const int startingTriangleNumber = 286;

    public override long Solve() {
      for (long i = startingTriangleNumber; i < long.MaxValue; i++) {
        var triangleNumber = GenerateTriangleNumber(i);
        if (triangleNumber.IsHexagonal() && triangleNumber.IsPentagonal()) {
          return long.Parse(triangleNumber.ToString());
        }
      }
      throw new Exception("Cannot find triangle number that is pentagonal and hexagonal under: " + int.MaxValue);
    }

    public long GenerateTriangleNumber(long n) {
      return (long)((n * (n + 1)) / 2);
    }
  }
}
