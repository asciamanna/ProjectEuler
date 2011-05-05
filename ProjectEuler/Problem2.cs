using System;
using System.Collections.Generic;
using System.Windows;

namespace ProjectEuler {
  public class Problem2 : Problem {
    //By considering the terms in the Fibonacci sequence whose values 
    //do not exceed four million, find the sum of the even-valued terms.
    public override void Solve() {
      var sequence = GenerateFibonacciSequence(4000000);
      var answer = CalculateEvenTermsSum(sequence);
      WriteAnswerToConsole("The sum of the even terms is: " + answer);
    }

    List<int> GenerateFibonacciSequence(int limit) {
      if (limit <= 2) {
        throw new ArgumentException("Cannot generate the sequence with one value");
      }
      var sequence = new List<int> {1, 2};
      int i = 0;
      int nextValue = 0;

      while (nextValue < limit) {
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
