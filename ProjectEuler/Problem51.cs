﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(51, "Find the smallest prime which, by changing the same part of the number, can form eight different primes.")]
  public class Problem51 : Problem {
    readonly int primeFamily;
    readonly HashSet<long> primes;
    public Problem51() : this(8) { }

    public Problem51(int primeFamily) {
      this.primeFamily = primeFamily;
      primes = Primes.CalculatePrimesBelow(999999);
    }
    public override long Solve() {
      var length = 5;
      var sameDigits = 2;
      var foundPrimes = FilterPrimes(length, sameDigits);
      return foundPrimes.Count;
    }

    HashSet<long> FilterPrimes(int length, int sameDigits) {
      var possiblePrimes = primes.Where(p => p.ToString().Length == 5);
      var patters = BuildPatters(possiblePrimes, sameDigits);
      return null;
    }

    HashSet<string> BuildPatters(IEnumerable<long> possiblePrimes, int sameDigits) {
      var patterns = new HashSet<string>();
      foreach (var prime in possiblePrimes) {
        var digitCountLookup = BuildDigitCountLookup(prime);
      }
      return null;
    }

    public static string BuildPattern(int numberForPattern, long prime) {
      throw new NotImplementedException();
    }

    public static Dictionary<int, int> BuildDigitCountLookup(long prime) {
      var digitCounts = new Dictionary<int, int>();
      var primeString = prime.ToString();
      foreach (var numberChar in primeString) {
        digitCounts[int.Parse(numberChar.ToString())] = primeString.Count(c => c == numberChar);
      }
      return digitCounts;
    }
  }
}
