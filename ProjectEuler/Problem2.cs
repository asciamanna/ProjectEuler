using System;
using System.Collections.Generic;
using System.Windows;

namespace ProjectEuler {
  public class Problem2 : Problem {
    //-----------------------------------------------------------------
    //By considering the terms in the Fibonacci sequence whose values 
    //do not exceed four million, find the sum of the even-valued terms.
    //Answer: 4613732
    //-----------------------------------------------------------------

    public override long Solve() {
      var sequence = FibonacciSequence.GenerateSequenceBelow(4000000);
     return CalculateEvenTermsSum(sequence);
    }

    int CalculateEvenTermsSum(List<int> sequence) {
      var sum = 0;
      foreach (int term in sequence) {
        if (IsEven(term)) {
          sum += term;
        }
      }
      return sum;
    }

    bool IsEven(int term) {
      return term % 2 == 0;
    }
  }
}
