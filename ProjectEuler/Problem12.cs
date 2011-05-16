using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem12 : Problem {
    readonly int moreThanNumberOfDivisors;

    public Problem12(int moreThanNumberOfDivisors) {
      this.moreThanNumberOfDivisors = moreThanNumberOfDivisors; 
    }
    public override long Solve() {
      for (int i = 1; i < int.MaxValue; i++) {
        var triangleNumber = CalculateNthTriangleNumber(i);
        var numberOfDivisors = CalculateNumberOfDivisors(triangleNumber);
        if (numberOfDivisors > moreThanNumberOfDivisors) {
          return triangleNumber;
        }
      }
      return 0;
    }

     int CalculateNumberOfDivisors(long triangleNumber) {
       var numberOfDivisors = 0;
       for (int i = 1; i <= triangleNumber; i++) {
         if (triangleNumber % i == 0) numberOfDivisors++;
       }
       return numberOfDivisors;
    }

     public static long CalculateNthTriangleNumber(int n) {
      return Enumerable.Range(1, n).Sum();
    }
  }
}
