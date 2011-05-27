using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler {
  public class Problem24 : Problem {
    List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    public override long Solve() {
      long permutationPositionToFind = 1000000;
      var permutationLength = numbers.Count;
      var permutation = string.Empty;

      var factorial = numbers.Count - 1;

      while(numbers.Count > 0) {
        var range = EulerMath.Factorial(factorial);
        var i = 1;
        while(range*i < permutationPositionToFind) { i++; }
        permutation+=numbers[i-1];
        permutationPositionToFind -= (long)(range*(i-1)+1);
        factorial--;
        numbers.RemoveAt(i-1);
      }
      return long.Parse(permutation);
    }
  }
}
