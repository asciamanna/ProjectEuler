using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(44, "Find the smallest pair of pentagonal numbers whose sum and difference is pentagonal.")]
  public class Problem44 : Problem {
    public override long Solve() {
      long minimizedD = long.MaxValue;

      var pentagonals = new HashSet<long> { GeneratePentagonal(1) };

      for (int i = 2; i < int.MaxValue; i++) {
        var pentagonal = GeneratePentagonal(i);
        foreach (var num in pentagonals) {
          if ((Math.Abs(pentagonal - num)).IsPentagonal()) {
            if ((pentagonal + num).IsPentagonal()) {
              return Math.Abs(pentagonal - num);
            }
          }
        }
        pentagonals.Add(pentagonal);
      }
      return minimizedD;
    }
    long GeneratePentagonal(int n) {
      return ((long)n * (3 * n - 1) / 2);
    }

    HashSet<long> GeneratePentagonalNumbers() {
      var pentagonals = new HashSet<long>();
      for (int n = 1; n < 1001; n++) {
        pentagonals.Add((long)n * (3 * n - 1) / 2);
      }
      return pentagonals;
    }

    bool SumAndDifferenceIsPentagonal(HashSet<long> pentagonals, int i, int j) {
      if (pentagonals.Contains(pentagonals.ElementAt(i) + pentagonals.ElementAt(j))) {
        //&& pentagonals.Contains(Math.Abs(pentagonals.ElementAt(j) - pentagonals.ElementAt(i)))) {
        return true;
      }
      return false;
    }


  }
}
