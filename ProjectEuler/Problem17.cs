using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem17 : Problem {
    //TODO: Add negatives.
    //TODO: Add numbers over 1000
    //TODO: add -teens to algorithm and remove from dictionary
    readonly long startingNumber;
    readonly long endingNumber;

    static Dictionary<int, string> numberLookup = new Dictionary<int,string> { 
        {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five" },
        {6, "six"}, {7, "seven" }, {8, "eight"}, {9, "nine"}, {10, "ten"},
        {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, 
        {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"},
        {19, "nineteen"}, {20, "twenty"}, {30, "thirty" }, {40, "forty" }, {50, "fifty"},
        {1000, "one thousand"} };

    public Problem17() : this(1, 1000) { }

    public Problem17(long startingNumber, long endingNumber) {
      if (startingNumber > endingNumber) throw new ArgumentException("starting number cannot exceed ending number");
      if (Math.Abs(startingNumber) > 1000 || Math.Abs(endingNumber) > 1000) 
        throw new ArgumentException("only supports numbers up to 1000");

      this.startingNumber = startingNumber;
      this.endingNumber = endingNumber;
    }

    public override long Solve() {
      var range = Enumerable.Range((int)startingNumber, (int)(endingNumber - startingNumber + 1));
      var writtenNumber = string.Empty;
      
      foreach (var number in range) {
        var numberString = string.Empty;

        if (numberLookup.TryGetValue(number, out numberString)) {
          writtenNumber += numberString;
        }
        else {
          writtenNumber += BuildNumberText(number);
        }
      }
      return writtenNumber.Replace(" ", string.Empty).Replace("-", string.Empty).Length;
    }

    public static string BuildNumberText(int number) {
      var writtenNumber = string.Empty;

      if (numberLookup.TryGetValue(number, out writtenNumber)) {
        return writtenNumber;
      }
      if (number > 99 && number < 1000) {
        if (number % 100 == 0) {
          return BuildHundredsNumber(number);
        }
        return BuildHundredsNumber(number) + " and " + BuildNumberText(number % 100);
      }
      if (number < 100) {
        if (number % 10 == 0) {
          return BuildTensNumber(number);
        }
        return BuildTensNumber(number) + " " + BuildNumberText(number % 10);
      }
      
      return writtenNumber;
    }

    static string BuildTensNumber(int number) {
      var writtenNumber = string.Empty;
      if (numberLookup.TryGetValue(number.RoundDownToTens(), out writtenNumber)) {
        return writtenNumber;
      }

      int tensNumber = number / 10;
      return numberLookup[tensNumber].EndsWith("t") ? numberLookup[tensNumber] + "y" : numberLookup[tensNumber] + "ty";
    }

    static string BuildHundredsNumber(int number) {
      int hundredsNumber = number / 100;
      return numberLookup[hundredsNumber] + " hundred";
    }
  }
}
