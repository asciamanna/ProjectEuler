using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(33, "Discover all the fractions with an unorthodox cancelling method.")]
  public class Problem33 : Problem {
    public override long Solve() {
      for (int numerator = 10; numerator < 99; numerator++) {
        for (int denominator = numerator + 1; denominator < 100; denominator++) {
          var fraction = new Fraction(numerator, denominator);
          if (fraction.HasCommonDigits()) {
             
             var commonDigitsRemovedFraction = RemoveCommonDigits(fraction);
            
            var reducedFraction = fraction.Reduce();
            if(fraction != reducedFraction) {
             
            }
          }
        }
      }
      return 0;
    }

    Fraction RemoveCommonDigits(Fraction fraction) {
      throw new NotImplementedException();
    }
  }

  public class Fraction {
    int numerator;
    int denominator;
    int gcf;

    public Fraction(int numerator, int denominator) {
      this.numerator = numerator;
      this.denominator = denominator;
      gcf = EulerMath.GreatestCommonFactor(numerator, denominator);
    }

    public Fraction Reduce() {
      return new Fraction(numerator / gcf, denominator / gcf);
    }

    public int Numerator {
     get { return numerator; }
    }

    public int Denominator {
     get { return denominator; }
    }

     public bool HasCommonDigits() {
       return numerator.ToString().Any(c => denominator.ToString().Contains(c));
    }
  }
}
