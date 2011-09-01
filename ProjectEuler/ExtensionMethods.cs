using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

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
      return PandigitalCheck(number, false);
    }

    public static bool IsPandigital(this long number) {
      return PandigitalCheck(number, false);
    }

    public static bool IsZeroToNPandigital(this int number) {
      return PandigitalCheck(number, true);
    }

    public static bool IsZeroToNPandigital(this long number) {
      return PandigitalCheck(number, true);
    }

    private static bool PandigitalCheck(long number, bool includeZero) {
      if (includeZero && !number.ToString().Contains('0')) return false;
      var digits = new HashSet<char>();
      foreach (var digit in number.ToString()) {
        if (!includeZero) {
          if (digit == '0') return false;
        }
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

    public static bool IsPalindromic(this BigInteger number) {
      var numberString = number.ToString();
      return numberString == new String(numberString.Reverse().ToArray());
    }

    public static bool IsPalindromic(this string number) {
      return number == new String(number.Reverse().ToArray());
    }

    public static long Concat(this long number, long append) {
      return long.Parse(number.ToString() + append.ToString());
    }

    public static BigInteger Concat(this BigInteger number, int append) {
      return BigInteger.Parse(number.ToString() + append.ToString());
    }

    public static int ToAlphabeticalPosition(this char letter) {
      return letter - 64;
    }

    public static bool IsPentagonal(this long number) {
      //http://en.wikipedia.org/wiki/Pentagonal_number

      double n = (Math.Sqrt(24 * number + 1) + 1) / 6;
      return n % 1 == 0;
    }

    public static bool IsHexagonal(this long number) {
      //http://en.wikipedia.org/wiki/Hexagonal_number

      double n = (Math.Sqrt(8 * number + 1) + 1) / 4;
      return n % 1 == 0;
    }

    public static bool IsPentagonal(this BigInteger number) {
      //http://en.wikipedia.org/wiki/Pentagonal_number

      decimal n = (decimal)(Sqrt(24 * number + 1) / 6);
      return n % 1 == 0;
    }

    public static bool IsHexagonal(this BigInteger number) {
      //http://en.wikipedia.org/wiki/Hexagonal_number

      decimal n = (decimal)((Sqrt(8 * number + 1) + 1) / 4);
      return n % 1 == 0;
    }

    public static BigInteger Reverse(this BigInteger number) {
      return BigInteger.Parse(new String(number.ToString().Reverse().ToArray()));
    }

   // http://community.devexpress.com/blogs/paulk/archive/2010/08/14/really-really-big-numbers-with-biginteger-in-net-4-0.aspx
   public static BigInteger Sqrt(BigInteger number) {
      // problem with lower numbers to to right bit shift
      int bitLength = number.ToByteArray().Length * 8 + 1;
      BigInteger G = number >> bitLength / 2;
      BigInteger LastG = BigInteger.Zero;
      BigInteger One = new BigInteger(1);
      while (true) {
        LastG = G;
        G = (number / G + G) >> 1;
        int i = G.CompareTo(LastG);
        if (i == 0) return G;
        if (i < 0) {
          if ((LastG - G).CompareTo(One) == 0)
            if ((G * G).CompareTo(number) < 0 &&
              (LastG * LastG).CompareTo(number) > 0) return G;
        }
        else {
          if ((G - LastG).CompareTo(One) == 0)
            if ((LastG * LastG).CompareTo(number) < 0 &&
              ((G * G).CompareTo(number) > 0)) return LastG;
        }
      }
    }
  }
}

