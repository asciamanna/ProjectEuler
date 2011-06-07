using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(32, "Find the sum of all numbers that can be written as pandigital products.")]
  public class Problem32 : Problem {
    const int MIN_ONE_DIGIT_PANDIGITAL = 1;
    const int MAX_ONE_DIGIT_PANDIGITAL = 9;
    const int MIN_THREE_DIGIT_PANDIGITAL = 123;
    const int MAX_THREE_DIGIT_PANDIGITAL = 987;
    //pandigital products to 9.
    //multiplier * multiplicand = product (product identity) 
    
    //must be of the form 3 digits * 2 digits = 4 digits
    // or                 1 digit * 4 digits = 4 digits

    SortedSet<int> pandigitalProducts = new SortedSet<int>();

    public override long Solve() {
      GeneratePandigitalProducts();

      for (int multiplier = 1; multiplier < 9; multiplier++) {
        for (int multiplicand = 1234; multiplicand < 9876; multiplicand++) {
          var identity = BuildIdentity(multiplier, multiplicand);
          if (identity.IsPandigital()) {
            pandigitalProducts.Add(multiplier * multiplicand);
          }
        }
      }
      return pandigitalProducts.Sum();
    }

    private void GeneratePandigitalProducts() {
      for (int multiplier = 123; multiplier < 987; multiplier++) {
        for (int multiplicand = 12; multiplicand < 98; multiplicand++) {
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
