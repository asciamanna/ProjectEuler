using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public static class Pandigitals {
    public static HashSet<long> Generate(int nDigit) {
      var numbers = Enumerable.Range(1, nDigit);
      var numberString = string.Empty;
      foreach (var number in numbers) {
        numberString += number;
      }
      return Permutations.Generate(long.Parse(numberString));
    }

    public static HashSet<long> GenerateZeroToN(int nDigit) {
      var numbers = Enumerable.Range(1, nDigit).ToList();
      numbers.Add(0);
      //append 0 at end so cast to long doesn't chop it off
      var numberString = string.Empty;
      foreach (var number in numbers) {
        numberString += number;
      }
      return Permutations.Generate(long.Parse(numberString));
    }
  }
}
