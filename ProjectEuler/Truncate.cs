using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public enum TruncateMethod {
    LeftToRight,
    RightToLeft,
  }

  public class Truncate {
    TruncateMethod method;
    string numberString;
    public Truncate(long number, TruncateMethod method) {
      this.numberString = number.ToString();
      this.method = method;
    }

    public bool CanTruncate() {
      return numberString.Length > 1;
    }

    public long CurrentValue() {
      return long.Parse(numberString);
    }

    public long NextValue() {
      if (!CanTruncate()) { throw new Exception("Cannot truncate a digit number any further"); }
      int indexToRemove;
      if (method == TruncateMethod.LeftToRight) {
        indexToRemove = 0;
      }
      else {
        indexToRemove = numberString.Length - 1;
      }
      numberString = numberString.Remove(indexToRemove, 1);
      return long.Parse(numberString);
    }
  }
}
