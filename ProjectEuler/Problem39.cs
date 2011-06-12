using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem39 : Problem {
    public override long Solve() {
      long maxNumberOfSolutions = 0;
      long currentNumberOfSolutions;
      int maxPerimeter = 0;

      var range = Enumerable.Range(1, 1000);
      foreach (var p in range) {
        currentNumberOfSolutions = 0;
        for (int a = 1; a < p; a++) {
          if (p * (p - 2 * a) % (2 * (p - a)) == 0) {
            currentNumberOfSolutions++;
            if (currentNumberOfSolutions > maxNumberOfSolutions) {
              maxNumberOfSolutions = currentNumberOfSolutions;
              maxPerimeter = p;
            }
          }
        }
      }
      return maxPerimeter;
    }
  }
}
