using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public static class Pandigitals {
    public static List<long> Generate(int nDigit) {
      var numbers = Enumerable.Range(1, nDigit);
      var numberString = string.Empty;
      foreach (var number in numbers) {
        numberString += number;
      }
      return Permutations.Generate(long.Parse(numberString));
    }
  }
}
