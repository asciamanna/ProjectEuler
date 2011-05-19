using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler {
  public class Problem16 : Problem {
    readonly int number;
    readonly int exponent;

    public Problem16(int number, int exponent) {
      this.number = number;
      this.exponent = exponent;
    }
    public override long Solve() {
      var bigInt = new BigInteger(Math.Pow(number, exponent));
      var bigIntString = bigInt.ToString();
      long sum = 0;
      foreach (char digit in bigIntString) {
        sum += Int32.Parse(digit.ToString());
      }
      return sum;
    }
  }
}
