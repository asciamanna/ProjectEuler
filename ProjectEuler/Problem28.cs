using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(28, "What is the sum of both diagonals in a 1001 by 1001 spiral?")]
  public class Problem28 : Problem {
    int squareSize;

    public Problem28() : this(1001) { }
    
    public Problem28(int squareSize) {
      this.squareSize = squareSize;
    }

    public override long Solve() {
      var sumOfDiagonals = 1; //base case, first value is 1.
      for(int i = 3; i <= squareSize; i+=2) {
        sumOfDiagonals += CalculateCornerNumbers(i).Sum();
      }
      return sumOfDiagonals;
    }
    
    List<int> CalculateCornerNumbers(int n) {
      return new List<int> { n * n, n * n - n + 1, n * n - 2 * n + 2, n * n - 3 * n + 3 };
    }

    //brute force.
    //public override long Solve() {
    //  var southEastDiagonal = new List<long> { 1 };
    //  var southWestDiagonal = new List<long> { 1 };
    //  var northWestDiagonal = new List<long> { 1 };
    //  var northEastDiagonol = new List<long> { 1 };
    //  long step = 2;
    //  long num = 3;
    //  while (num <= maxNumber) {
    //    southEastDiagonal.Add(num);
    //    southWestDiagonal.Add(num + step);
    //    northWestDiagonal.Add(num + (2 * step));

    //    var lastStepOfIteration = num + (3 * step);
    //    northEastDiagonol.Add(lastStepOfIteration);
    //    step +=2;
    //    num = lastStepOfIteration + step;
    //  }
    //  return southEastDiagonal.Union(southWestDiagonal).Union(northWestDiagonal).Union(northEastDiagonol).Sum();
    //}
  }
}
