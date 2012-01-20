using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem61 : Problem {

    public override long Solve() {
      var triangleNumbers = GenerateFourDigitTriangleNumbers();
      var squareNumbers = GenerateFourDigitSquareNumbers();
      var pentagonalNumbers = GenerateFourDigitPentagonalNumbers();
      var hexagonalNumbers = GenerateFourDigitHexagonalNumbers();
      var septagonalNumbers = GenerateFourDigitSeptagonalNumbers();
      var octagonalNumbers = GenerateFourDigitOctagonalNumbers();
      
      return 0;
    }

    HashSet<int> GenerateFourDigitTriangleNumbers() {
      var triangleNumbers = new HashSet<int>();

      for (int i = 1; i < 1000; i++) {
        triangleNumbers.Add(i * (i + 1) / 2);
      }
      triangleNumbers.RemoveWhere(tn => tn / 1000 >= 1 && tn / 1000 < 10);
      return triangleNumbers;
    }

    HashSet<int> GenerateFourDigitSquareNumbers() {
      var squareNumbers = new HashSet<int>();

      for (int i = 1; i < 100; i++) {
        squareNumbers.Add(i * i);
      }
      squareNumbers.RemoveWhere(sn => sn / 1000 >= 1 && sn / 1000 < 10);
      return squareNumbers;
    }
    HashSet<int> GenerateFourDigitPentagonalNumbers() {
      throw new NotImplementedException();
    }

    HashSet<int> GenerateFourDigitHexagonalNumbers() {
      throw new NotImplementedException();
    }

    HashSet<int> GenerateFourDigitSeptagonalNumbers() {
      throw new NotImplementedException();
    }

    HashSet<int> GenerateFourDigitOctagonalNumbers() {
      throw new NotImplementedException();
    }


  
  }
}
