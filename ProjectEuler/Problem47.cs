using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(47, "Find the first four consecutive integers to have four distinct primes factors.")]
  public class Problem47 : Problem {
    public override long Solve() {
      int numberOfDistinctPrimeFactors = 4;
      for (int i = 1; i < int.MaxValue; i++) {
        if (Factors.CalculateDistinctPrimeFactors(i).Count == numberOfDistinctPrimeFactors &&
          Factors.CalculateDistinctPrimeFactors(i + 1).Count == numberOfDistinctPrimeFactors &&
          Factors.CalculateDistinctPrimeFactors(i + 2).Count == numberOfDistinctPrimeFactors &&
          Factors.CalculateDistinctPrimeFactors(i + 3).Count == numberOfDistinctPrimeFactors) {
            return i;
        }
      }
      throw new Exception("Cannot find answer below " + int.MaxValue);
    }
  }
}
