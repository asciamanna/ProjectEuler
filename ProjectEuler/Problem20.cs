using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(20, "")]
  public class Problem20 : Problem {
    readonly long number;
    public Problem20() : this(100) { }

    public Problem20(long number) {
      this.number = number;
    }

    public override long Solve() {
      var stringFactorial = EulerMath.Factorial(number).ToString();
      var listOfInts = new List<int>();
      foreach(var digit in stringFactorial) {
        listOfInts.Add(Int32.Parse(digit.ToString()));
      }

      return listOfInts.Sum();
    }
  }
}
