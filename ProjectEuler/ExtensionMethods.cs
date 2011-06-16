﻿using System;
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
      double check =  (Math.Sqrt(24 * number + 1) + 1) / 6;
      return check % 1 == 0;
    }
  
  }
}

