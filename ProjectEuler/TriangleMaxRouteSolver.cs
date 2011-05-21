using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class TriangleMaxRouteSolver {
    List<List<long>> triangle;
    public TriangleMaxRouteSolver(List<List<long>> triangle) {
      this.triangle = triangle;
    }

    public long CacluateSumOfMaxRoute() {

      for (int row = 0; row < triangle.Count; row++) {
        for (int item = 0; item < triangle[row].Count; item++) {

          if (!FirstElementOfTriangle(row, item)) {
            var upperRightLocationExists = UpperRightLocationExists(row, item);
            var upperLeftLocationExists = UpperLeftLocationExists(row, item);

            if (upperRightLocationExists && upperLeftLocationExists) {
              triangle[row][item] = Math.Max(CurrentNumber(row, item) + UpperRight(row, item), CurrentNumber(row, item) + UpperLeft(row, item));
            }
            else if (!upperRightLocationExists) {
              triangle[row][item] = CurrentNumber(row, item) + UpperLeft(row, item);
            }
            else if (!upperLeftLocationExists) {
              triangle[row][item] = CurrentNumber(row,item) + UpperRight(row, item);
            }
          }
        }
      }
      return FindMaxSum();
    }

    bool FirstElementOfTriangle(int row, int item) {
      return row == 0 && item == 0;
    }

    long CurrentNumber(int row, int item) {
      return triangle[row][item];
    }

    long FindMaxSum() {
      return triangle.Last().Max();
    }

    long UpperLeft(int row, int item) {
      return triangle[row - 1][item - 1];
    }

    long UpperRight(int row, int item) {
      return triangle[row - 1][item];
    }

    bool UpperLeftLocationExists(int y, int x) {
      return (y - 1 < triangle.Count && y - 1 >= 0) && (x - 1 < triangle[y - 1].Count && x - 1 >= 0);
    }

    bool UpperRightLocationExists(int y, int x) {
      return (y - 1 < triangle.Count && y - 1 >= 0) && (x < triangle[y - 1].Count && x >= 0);
    }
  }
}
