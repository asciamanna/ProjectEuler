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
      var sequence = GenerateFibonacciSequence(4000000);
     return CalculateEvenTermsSum(sequence);
    }

    List<int> GenerateFibonacciSequence(int limit) {
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
