using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ProjectEuler {
  public class Problem23 : Problem {
    public override long Solve() {
      //All numbers greater than 28123 can be written as the sum 
      //of two abundant numbers.
      const int MAXNUM = 28123;
      long sum = 0;

      var abundantNumbers = Factors.AbundantNumbersBelow(MAXNUM);
      for (int number = 1; number < MAXNUM; number++) {
        bool isSumOfAbundantNumbers = false;
        for (int i = number - 1; i > 0; i--) {
          if (abundantNumbers[i] && abundantNumbers[number - i]) {
            isSumOfAbundantNumbers = true;
            break;
          }
        }
        if (!isSumOfAbundantNumbers) sum += number;
      }
      return sum;
    }
  }
}
