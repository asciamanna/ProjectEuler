﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem6 : Problem {
    //-----------------------------
    //Find the difference between the sum of 
    //the squares of the first one hundred natural
    //numbers and the square of the sum.
    //
    //Brute Force: .016 seconds
    //------------------------------
    readonly IEnumerable<int> naturalNumbers;

    public Problem6(int numberOfNaturalNumbers) {
      naturalNumbers = Enumerable.Range(1, numberOfNaturalNumbers);
    }

    public override long Solve() {
     return SquareOfSum() - SumOfSquares();
    }

    long SquareOfSum() {
      return (long)Math.Pow(naturalNumbers.Sum(), 2);
    }

    long SumOfSquares() {
      return naturalNumbers.Sum(nn => (long)Math.Pow(nn,2));
    }
  }
}