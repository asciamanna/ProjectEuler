using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler {
  public class Problem25 : Problem {
    int maxNumberOfDigits;
    List<BigInteger> sequence;

    public Problem25() : this(1000) { }
    
    public Problem25(int numberOfDigits) {
      this.maxNumberOfDigits = numberOfDigits;
      sequence = new List<BigInteger> { BigInteger.One, BigInteger.One };
    }

    BigInteger Fibonacci(int n) {
      var nextInSequence = sequence[n - 3] + sequence[n - 2];
      sequence.Add(nextInSequence);
      return nextInSequence;
    }

    public override long Solve() {
      BigInteger number = new BigInteger(0);
      for (int i = 3; i < int.MaxValue; i++) {
        number = Fibonacci(i);
        if (number.ToString().Length >= maxNumberOfDigits) break;
      }
      return sequence.Count;
    }
  }
}
