using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem17 : Problem {
    readonly long startingNumber;
    readonly long endingNumber;
    long letterCount;
    Dictionary<int, string> numberLookup;

    public Problem17(long startingNumber, long endingNumber) {
      if (startingNumber > endingNumber) throw new ArgumentException("starting number cannot exceed ending number");

      this.startingNumber = startingNumber;
      this.endingNumber = endingNumber;
      letterCount = 0;
      PopulateNumberLookup();
    }

    void PopulateNumberLookup() {
      numberLookup = new Dictionary<int, string> {
        {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five" },
        {6, "six"}, {7, "seven" }, {8, "eight"}, {9, "nine"}, {10, "ten"},
        {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, 
        {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"},
        {19, "nineteen"}, {20, "twenty"}
      };
    }
    public override long Solve() {
      var range = Enumerable.Range((int)startingNumber, (int)(endingNumber - startingNumber));
      foreach (var number in range) {
        var writtenNumber = string.Empty;
        //if (number 
        if (numberLookup.TryGetValue(number, out writtenNumber)) {
          letterCount += writtenNumber.Length;
        }
      }
      return 0;
    }
  }
}
