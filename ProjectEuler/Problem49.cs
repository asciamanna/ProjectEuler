using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(49, "Find arithmetic sequences, made of prime terms, whose four digits are permutations of each other.")]
  public class Problem49 : Problem {
    public override long Solve() {
      for (int number = 1490; number < 9999; number++) {
        var perms = Permutations.Generate(1490);
        int permsCount = 0;
        var permsList = new List<long>();

        perms.ToList().ForEach(p => { if (Primes.IsPrime(p)) permsCount++; permsList.Add(p); });
        if (permsCount >= 4) {
          foreach (var perm in permsList) {
            Console.Write(" " + perm);
          }
          Console.WriteLine();
        }
      }
      return 0;
    }
  }
}
