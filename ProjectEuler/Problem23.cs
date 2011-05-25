using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ProjectEuler {
  public class Problem23 : Problem {
    Dictionary<int, bool> abundantLookup = new Dictionary<int, bool>();

    //public override long Solve() {
    //  //All numbers greater than 28123 can be written as the sum 
    //  //of two abundant numbers.
    //  long sum = 0;
    //  bool isSumOfTwoAbundantNumbers = false;
    //  for (int i = 1; i <= 28123; i++) {
    //    var abundantNumbers = Factors.CalculateAbundantNumbersBelow(i);
    //    foreach (var abundantNumber in abundantNumbers) {
    //      if (i > abundantNumber && abundantNumbers.Contains(i - abundantNumber)) {
    //        isSumOfTwoAbundantNumbers = true;
    //        break;
    //      }
    //    }
    //    if (!isSumOfTwoAbundantNumbers) sum += i;
    //  }
    //  return sum;
    //}

    public override long Solve() {
      //All numbers greater than 28123 can be written as the sum 
      //of two abundant numbers.
      long sum = 0;
      for (int i = 1; i <= 28123; i++) {
        var pairedAddends = CalculatePairedAddends(i);
        bool isSumOfAbundantNumbers = false;
        foreach (var pair in pairedAddends) {
          if (IsAbundant(pair[0]) && IsAbundant(pair[1])) {
            isSumOfAbundantNumbers = true;
            break;
          }
        }
        if (!isSumOfAbundantNumbers) sum += i;
      }
      return sum;
    }

    bool IsAbundant(int number) {
      if (abundantLookup.ContainsKey(number)) return abundantLookup[number];
      var isAbundant = Factors.IsAbundant(number);
      abundantLookup.Add(number, isAbundant);
      return isAbundant;
    }

    List<List<int>> CalculatePairedAddends(int number) {
      var pairedAddends = new List<List<int>>();
      for (int i = number - 1; i >= number/2; i--) {
        pairedAddends.Add(new List<int> { number - i, i });
      }
      return pairedAddends;
    }
  }
}
