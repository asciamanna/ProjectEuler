using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem38 : Problem {
    public override long Solve() {
      long largestPandigital = 0;
      long potentialPandigital;

      //n has to be > 1 the number cannot be larger than a 4 digit number,
      //since a 5 digit number could not be multiplied by 2 and concatted with itself
      //and still be 1 - 9 pandigital
      int LARGEST_FOUR_DIGIT_PANDIGITAL = 9876;
      var numberRange = Enumerable.Range(1, LARGEST_FOUR_DIGIT_PANDIGITAL);
     
      foreach (var number in numberRange) {
        int n = 1;
        potentialPandigital = 0;
        while (DoesntExceedPandigitalLength(potentialPandigital)) {
          potentialPandigital = potentialPandigital.Concat(number * n);
          if (potentialPandigital.IsPandigital() && potentialPandigital > largestPandigital) {
            largestPandigital = potentialPandigital;
          }
          n++;
        }
      }
      return largestPandigital;
    }

    bool DoesntExceedPandigitalLength(long largestPandigital) {
      return largestPandigital.ToString().Length <= 9; 
    }
  }
}
