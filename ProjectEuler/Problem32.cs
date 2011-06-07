using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(32, "Find the sum of all numbers that can be written as pandigital products.")]
  public class Problem32 : Problem {
    const int MIN_ONE_DIGIT_PANDIGITAL = 1;
    const int MAX_ONE_DIGIT_PANDIGITAL = 9;
    const int MIN_TWO_DIGIT_PANDIGITAL = 12;
    const int MAX_TWO_DIGIT_PANDIGITAL = 98;
    const int MIN_THREE_DIGIT_PANDIGITAL = 123;
    const int MAX_THREE_DIGIT_PANDIGITAL = 987;
    const int MIN_FOUR_DIGIT_PANDIGITAL = 1234;
    const int MAX_FOUR_DIGIT_PANDIGITAL = 9876;
    //pandigital products to 9.
    //multiplier * multiplicand = product (product identity) 
    
    //must be of the form 3 digits * 2 digits = 4 digits
    // or                 1 digit * 4 digits = 4 digits

    SortedSet<int> pandigitalProducts = new SortedSet<int>();

    public override long Solve() {
      var twoDigitRange = Enumerable.Range(MIN_TWO_DIGIT_PANDIGITAL, MAX_TWO_DIGIT_PANDIGITAL - MIN_TWO_DIGIT_PANDIGITAL + 1);
      var threeDigitRange = Enumerable.Range(MIN_THREE_DIGIT_PANDIGITAL, MAX_THREE_DIGIT_PANDIGITAL - MIN_THREE_DIGIT_PANDIGITAL + 1);
      GeneratePandigitalProducts(twoDigitRange, threeDigitRange);

      var oneDigitRange = Enumerable.Range(MIN_ONE_DIGIT_PANDIGITAL, MAX_ONE_DIGIT_PANDIGITAL - MIN_ONE_DIGIT_PANDIGITAL + 1);
      var fourDigitRange = Enumerable.Range(MIN_FOUR_DIGIT_PANDIGITAL, MAX_FOUR_DIGIT_PANDIGITAL - MIN_FOUR_DIGIT_PANDIGITAL + 1);

      GeneratePandigitalProducts(oneDigitRange, fourDigitRange);
      return pandigitalProducts.Sum();
    }

    private void GeneratePandigitalProducts(IEnumerable<int> multiplierRange, IEnumerable<int> multiplicandRange) {
      foreach(var multiplier in multiplierRange) {
       foreach(var multiplicand in multiplicandRange) {
          var identity = BuildIdentity(multiplier, multiplicand);
          if (identity.IsPandigital()) {
            pandigitalProducts.Add(multiplier * multiplicand);
          }
        }
      }
    }

    static long BuildIdentity(int multiplier, int multiplicand) {
      return long.Parse(multiplier.ToString() + multiplicand.ToString() + (multiplier * multiplicand).ToString());
    }
  }
}
