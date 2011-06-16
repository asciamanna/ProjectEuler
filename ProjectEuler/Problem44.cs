using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(44, "Find the smallest pair of pentagonal numbers whose sum and difference is pentagonal.")]
  public class Problem44 : Problem {
    public override long Solve() {
     
      var pentagonals = new HashSet<long> { GeneratePentagonal(1) };

      for (int i = 2; i < int.MaxValue; i++) {
        var pentagonal = GeneratePentagonal(i);
        foreach (var foundPentagonal in pentagonals) {
          if (IsDifferencePentagonal(pentagonal, foundPentagonal) && IsSumPentagonal(pentagonal, foundPentagonal)) {
            return Math.Abs(pentagonal - foundPentagonal);
          }
        }
        pentagonals.Add(pentagonal);
      }
      throw new Exception("Cannot find pentagonal pair below: " + int.MaxValue);
    }

    static long GeneratePentagonal(int n) {
      return ((long)n * (3 * n - 1) / 2);
    }

    static bool IsSumPentagonal(long pentagonal, long num) {
      return (pentagonal + num).IsPentagonal();
    }

    static bool IsDifferencePentagonal(long pentagonal, long num) {
      return (Math.Abs(pentagonal - num)).IsPentagonal();
    }
  }
}
