using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(28, "What is the sum of both diagonals in a 1001 by 1001 spiral?")]
  public class Problem28 : Problem {
    int maxNumber;
    public Problem28() : this(1001) { }
    public Problem28(int squareSize) {
      this.maxNumber = squareSize * squareSize;
    }
    
    public override long Solve() {
      var southEastDiagonal = new List<long> { 1 };
      var southWestDiagonal = new List<long> { 1 };
      var northWestDiagonal = new List<long> { 1 };
      var northEastDiagonol = new List<long> { 1 };
      long step = 2;
      long num = 3;
      while (num <= maxNumber) {
        southEastDiagonal.Add(num);
        southWestDiagonal.Add(num + step);
        northWestDiagonal.Add(num + (2 * step));
        
        var lastStepOfIteration = num + (3 * step);
        northEastDiagonol.Add(lastStepOfIteration);
        step +=2;
        num = lastStepOfIteration + step;
      }
      return southEastDiagonal.Union(southWestDiagonal).Union(northWestDiagonal).Union(northEastDiagonol).Sum();
    }
  }
}
