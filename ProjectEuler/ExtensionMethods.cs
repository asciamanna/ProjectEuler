using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public static class ExtensionMethods {
    public static bool IsEven(this long n) {
      return(n & 1) == 0;
    }

    public static bool IsEven(this int n) {
      return (n & 1) == 0;
    }

    public static bool IsOdd(this long n) {
      return (n & 1) != 0;
    }

    public static bool IsOdd(this int n) {
      return (n & 1) != 0;
    }

    public static int RoundDownToTens(this int n) {
      if (n > 10 && n < 100)
      return ((int)n / 10) * 10;
      return 0;
    }

    public static bool IsPandigital(this int number) {
      return PandigitalCheck(number);
    }

    public static bool IsPandigital(this long number) {
      return PandigitalCheck(number);
    }

    private static bool PandigitalCheck(long number) {
      var digits = new SortedSet<char>();
      foreach (var digit in number.ToString()) {
        if (digit == '0') return false;
        digits.Add(digit);
      }
      return digits.Count == number.ToString().Length;
    }

    public static string ToBinary(this int number) {
      return Convert.ToString(number, 2);
    }

    public static bool IsPalindromic(this int number) {
      var numberString = number.ToString();
      return numberString == new String(numberString.Reverse().ToArray());
    }

    public static bool IsPalindromic(this string number) {
      return number == new String(number.Reverse().ToArray());
    }
  
  }
}

