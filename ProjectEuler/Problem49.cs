using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(49, "Find arithmetic sequences, made of prime terms, whose four digits are permutations of each other.")]
  public class Problem49 : Problem {
    public override long Solve() {
      for (int number = 1490; number < 9999; number++) {
        var perms = Permutations.Generate(number).Where(p => p.ToString().Length == 4);
        var permsList = new List<long>();

        perms.ToList().ForEach(p => { if (Primes.IsPrime(p)) permsList.Add(p); });
        if (permsList.Count >= 4) {
          var sequence = FindSequence(permsList);
          if (sequence.Count > 0 && !sequence.Contains(1487)) {
            return long.Parse(sequence[0].ToString() + sequence[1].ToString() + sequence[2].ToString());
          }
        }
      }
      throw new Exception("Cannot find sequence....you messed it up");
    }

    public List<long> FindSequence(List<long> permsList) {
      permsList.Sort();
      var sequence = new List<long>();

      for (int a1 = 0; a1 < permsList.Count; a1++) {
        for (int a2 = 0; a2 < permsList.Count; a2++) {
          if (a1 != a2) {
            var differnce = permsList[a2] - permsList[a1];
            sequence.Add(permsList[a1]);
            sequence.Add(permsList[a2]);
            for (int i = a2; i < permsList.Count; i++) {
              if (permsList[i] - permsList[a2] == differnce) {
                sequence.Add(permsList[i]);
              }
            }
            if (sequence.Count == 3) return sequence;
          }
          sequence.Clear();
        }
      }
      return sequence;
    }
  }
}
