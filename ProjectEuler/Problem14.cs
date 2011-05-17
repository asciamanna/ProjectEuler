using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem14 : Problem {
    readonly int startingNumberLimit;
    int longestChain = 0;
    int numberThatCreatesLongestChain = 0;

    public Problem14(int startingNumberLimit) {
      this.startingNumberLimit = startingNumberLimit;
    }

    public override long Solve() {
      for (int i = 2; i <= startingNumberLimit; i++) {
        var sequence = CalculateSequence(i);
        if (longestChain <= sequence.Count) {
          longestChain = sequence.Count;
          numberThatCreatesLongestChain = i;
        }
      }
      return numberThatCreatesLongestChain;
    }

    public static List<int> CalculateSequence(int n) {
      List<int> sequence = new List<int> { n };
      var result = n;
      while (result > 1) {
        result = IsEven(result) ? EvenSequenceIteration(result) : OddSequenceIteration(result);
        sequence.Add(result);
      }
      return sequence;
    }

    static int EvenSequenceIteration(int n) {
      return n / 2;
    }

    static int OddSequenceIteration(int n) {
      return 3 * n + 1;
    }

    static bool IsEven(int i) {
      return (i & 1) == 0;
    }
  }
}
