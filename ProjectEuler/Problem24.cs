using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler {
  [EulerProblem(24, "")]
  public class Problem24 : Problem {
    List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    public override long Solve() {
      int N = numbers.Count;
      string permutation = "";
      int permutationToFind = 1000000 - 1;

      for (int i = 1; i < N; i++) {
        int location = (int)(permutationToFind / EulerMath.Factorial(N - i));
        permutationToFind = (int)(permutationToFind % EulerMath.Factorial(N - i));
        permutation = permutation + numbers[location];
        numbers.RemoveAt(location);
        if (permutationToFind == 0) {
          break;
        }
      } for (int i = numbers.Count - 1; i >= 0; i--) {
        permutation+= numbers[i];
      }
      return long.Parse(permutation);
    }
  }
}
