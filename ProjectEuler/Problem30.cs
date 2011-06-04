using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(30, "Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.")]
  public class Problem30 : Problem {
    int exponent;
    public Problem30() : this(5) { }
    public Problem30(int exponent) {
      this.exponent = exponent;
    }
    public override long Solve() {
      long finalSum = 0;
      int startingNumber = 2;
      int endingNumber = GenerateEndingNumber();
      var range = Enumerable.Range(startingNumber, endingNumber - startingNumber + 1);
      foreach (int num in range) {
        if (SumOfPowers(num) == (long)num) {
          finalSum += num;
        }
      }
      return finalSum;
    }

    int SumOfPowers(int num) {
      if (num / 10 < 1) return (int)Math.Pow(num, exponent);

      int next = num / 10;
      int tens = num % 10;
      return (int) Math.Pow(tens, exponent) + SumOfPowers(next); 
    }

    int GenerateEndingNumber() {
      //the largest possible ending number

      int numberOfDigits = exponent;
      var endingNumber = LargestPossibleNumber(numberOfDigits);
      while(numberOfDigits <= endingNumber.ToString().Length) {
        endingNumber = LargestPossibleNumber(++numberOfDigits);
      }
      return endingNumber;
    }

    int LargestPossibleNumber(int numberOfDigits) {
      var endingNumber = string.Join(string.Empty, Enumerable.Repeat("9", numberOfDigits));
      return SumOfPowers(int.Parse(endingNumber));
    }
  }
}
