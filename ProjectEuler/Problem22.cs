using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProjectEuler {
  public class Problem22 : Problem {
    Dictionary<string, long> scoreLookup = new Dictionary<string, long>();

    public override long Solve() {
      int positionInFile = 1;
      long totalNameScores = 0;

      var names = File.ReadAllText(@".\Data\Problem22\names.txt").Replace("\"", string.Empty).Split(',').ToList();
      names.Sort();
      names.ForEach(n => scoreLookup.Add(n, positionInFile++));

      foreach (var name in names) {
        totalNameScores += CalculateAlphabeticalValue(name) * scoreLookup[name];
      }
      return totalNameScores;
    }

    int CalculateAlphabeticalValue(string name) {
      int alphabeticalValue = 0;
      foreach (char c in name.ToUpper()) {
        alphabeticalValue += AsciiToAlphabeticalPosition(c);
      }
      return alphabeticalValue;
    }

    int AsciiToAlphabeticalPosition(char c) {
      return c - 64;
    }
  }
}
