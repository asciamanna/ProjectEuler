using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
      var possiblePrimes = primes.Where(p => p.ToString().Length == length);
      var patterns = BuildPatterns(possiblePrimes, sameDigits);
      foreach (var pattern in patterns) {
        var regEx = ConvertPatternToRegex(pattern);
      }
      return null;
    }

    public static string ConvertPatternToRegex(string pattern) {
      return Regex.Replace(pattern, @"*", @"(d{1})", RegexOptions.IgnoreCase);
    }

    //test this.  could be a problem with same digit repeated elsewhere in number.

    HashSet<string> BuildPatterns(IEnumerable<long> possiblePrimes, int sameDigits) {
      var patterns = new HashSet<string>();
      foreach (var prime in possiblePrimes) {
        var digitCountLookup = BuildDigitCountLookup(prime);
        var primesWithMulitpleDigits = new List<long>();
        for (int i = 0; i < 10; i++) {
          if (digitCountLookup[i] > sameDigits) {
            patterns.Add(BuildPattern(i, prime));
          }
        }
      }
      return patterns;
    }

    public static string BuildPattern(int numberForPattern, long prime) {
      return prime.ToString().Replace(numberForPattern.ToString().ToCharArray()[0], '*');
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
