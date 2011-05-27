using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler {
  public static class FibonacciSequence {
    public static List<int> GenerateSequenceBelow(int limit) {
      if (limit < 2) {
        return new List<int> { 1 };
      }

      var sequence = new List<int> { 1, 2 };
      int i = 0;
      int nextValue = 0;

      while (nextValue <= limit) {
        nextValue = sequence[i] + sequence[i + 1];
        sequence.Add(nextValue);
        i++;
      }
      return sequence;
    }

    public static BigInteger Fibonacci(BigInteger n) {
      return (n < 2) ? 1 : Fibonacci(n - 2) + Fibonacci(n - 1);
    }
  }
}
