using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
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

    public override string ToString() {
      return string.Format("{0}/{1}", numerator, denominator);
    }

    public override bool Equals(object obj) {
      var that = obj as Fraction;
      return this.Numerator == that.Numerator && this.Denominator == that.Denominator;
    }

    public static Fraction operator *(Fraction f1, Fraction f2) {
      return new Fraction(f1.Numerator * f2.Numerator, f1.Denominator * f2.Denominator);
    }

    public override int GetHashCode() {
      return base.GetHashCode();
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

    public decimal AsDecimal() {
      return (decimal)numerator / denominator;
    }

    public bool CanBeReducedTo(Fraction fraction) {
      if (numerator == 0 || denominator == 0 || fraction.Numerator == 0 || fraction.Denominator == 0) return false;
      return this.AsDecimal() == fraction.AsDecimal();
    }
  }
}
