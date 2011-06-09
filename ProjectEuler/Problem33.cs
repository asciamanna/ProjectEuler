using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectEuler {
  [EulerProblem(33, "Discover all the fractions with an unorthodox cancelling method.")]
  public class Problem33 : Problem {
    public override long Solve() {
      var curiousFractions = new List<Fraction>();

      for (int numerator = 11; numerator < 99; numerator++) {
        for (int denominator = numerator + 1; denominator < 100; denominator++) {
          var fraction = new Fraction(numerator, denominator);

          if (fraction.HasCommonDigits() && !IsTrivial(fraction)) {
            var fractionWithCommonDigitsRemoved = RemoveCommonDigits(fraction);
            if (fraction.CanBeReducedTo(fractionWithCommonDigitsRemoved)) {
              curiousFractions.Add(fraction);
            }
          }
        }
      }
      var productOfFractions = curiousFractions.Aggregate((product, nextFraction) => product * nextFraction);
      var reduced = productOfFractions.Reduce();
      return reduced.Denominator;
    }

    private bool IsTrivial(Fraction fraction) {
      return fraction.Numerator % 10 == 0 || fraction.Denominator % 10 == 0;
    }

    Fraction RemoveCommonDigits(Fraction fraction) {
      var commonDigit = FindCommonDigit(fraction);
      var regex = new Regex(commonDigit.ToString());
      var modifiedNumerator = regex.Replace(fraction.Numerator.ToString(), string.Empty, 1);
      var modifiedDenominator = regex.Replace(fraction.Denominator.ToString(), string.Empty, 1);

      return new Fraction(int.Parse(modifiedNumerator), int.Parse(modifiedDenominator));
    }

    char FindCommonDigit(Fraction fraction) {
      foreach (var c in fraction.Numerator.ToString()) {
        if (fraction.Denominator.ToString().Contains(c)) return c;
      }
      return char.MinValue;
    }
  }




}
