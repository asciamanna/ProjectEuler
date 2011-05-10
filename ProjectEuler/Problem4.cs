using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem4 : Problem {
    //----------------------------------------------------------------------------
    //A palindromic number reads the same both ways. The largest palindrome made 
    //from the product of two 2-digit numbers is 9009 = 91  99.
    //Find the largest palindrome made from the product of two 3-digit numbers. 
    //----------------------------------------------------------------------------
    
    //TODO: divisble by 11??
    //TODO: set inner loop to current value of outer loop
    //TODO: only check to smallest x digit number.
    
    readonly int numberOfDigits;
    public Problem4(int numberOfDigits) {
      this.numberOfDigits = numberOfDigits;
    }


    public override long Solve() {
      var palindromes = new List<int>();
      var startingNumber = BuildStartingNumber(numberOfDigits);
      var maxNumber = 0;

      for (int factor1 = startingNumber; factor1 > 0; factor1--) {
        for (int factor2 = startingNumber; factor2 > 0; factor2--) {
          var product = factor1 * factor2;
          if (IsPalindrome(product)) {
            if (product > maxNumber) maxNumber = product;
          }
        }
      }
      return maxNumber; 
    }

    int BuildStartingNumber(int numberOfDigits) {
      var numberString = new String('9', numberOfDigits);
      return Int32.Parse(numberString);
    }

    bool IsPalindrome(int product) {
      var productString = product.ToString();
      var reversedString = new String(productString.Reverse().ToArray());
      return productString == reversedString;
    }

  }
}
