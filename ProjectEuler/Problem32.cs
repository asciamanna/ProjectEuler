using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(32, "Find the sum of all numbers that can be written as pandigital products.")]
  public class Problem32 : Problem {
    //pandigital products to 9.
    //multiplier * multiplicand = product 
    //need pandigital to 9.
    //must be of the form 3 digits * 2 digits = 4 digits
    // or                 2 digits * 3 digits = 4 digits
    //since can't get a smaller product when mulitplying two positive numbers.

    List<int> pandigitalProducts = new List<int>();

    public override long Solve() {
      var multiplier = new PandigitalNumber(123);
      var multiplicand = new PandigitalNumber(12);
      while (DoesntExceedPandigitalLength(multiplier.Current, multiplicand.Current, multiplier.Current * multiplicand.Current)) {
        if (IsPandigital(multiplier.Current, multiplicand.Current, multiplier.Current * multiplicand.Current)) {
          pandigitalProducts.Add(multiplier.Current * multiplicand.Current);
        }
        multiplicand.Next();
        multiplier.Next();
      }
      return pandigitalProducts.Distinct().Sum();
    }

    private bool DoesntExceedPandigitalLength(params int[] values) {
      var totalDigitCount = 0;
      foreach (var value in values) {
        totalDigitCount += value.ToString().Length;
      }
      return totalDigitCount <= 9;
    }

    private bool IsPandigital(params int[] values) {
      var listOfDigits = new List<char>();
      foreach (var value in values) {
        foreach (var digit in value.ToString()) {
          if (listOfDigits.Contains(digit)) return false;
          listOfDigits.Add(digit);
        }
      }
      return !listOfDigits.Contains('0') || listOfDigits.Count != 9;
    }
  }

  public class PandigitalNumber {

    int startRange;
    int endRange;
    int currentNumber;

    public PandigitalNumber(int startingNumber) {
      this.currentNumber = startingNumber;
    }

    public int Current {
      get { return currentNumber; }
    }

    public int Next() {
      currentNumber++;
      while (AnyDigitsRepeat(currentNumber) || currentNumber.ToString().Contains('0')) {
        currentNumber++;
      }
      return currentNumber;
    }

    bool AnyDigitsRepeat(int number) {
      List<char> digitsFound = new List<char>();
      foreach (var digit in number.ToString()) {
        if (digitsFound.Contains(digit)) return true;
        digitsFound.Add(digit);
      }
      return false;
    }
  }
}
