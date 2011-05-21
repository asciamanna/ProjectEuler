using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem18 : Problem {
    static List<List<int>> triangle = new List<List<int>> {
      new List<int>{75},
      new List<int>{95, 64},
      new List<int>{17, 47, 82},
      new List<int>{18, 35, 87, 10},
      new List<int>{20, 04, 82, 47, 65},
      new List<int>{19, 01, 23, 75, 03, 34},
      new List<int>{88, 02, 77, 73, 07, 63, 67},
      new List<int>{99, 65, 04, 28, 06, 16, 70, 92},
      new List<int>{41, 41, 26, 56, 83, 40, 80, 70, 33},
      new List<int>{41, 48, 72, 33, 47, 32, 37, 16, 94, 29},
      new List<int>{53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14},
      new List<int>{70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57},
      new List<int>{91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48},
      new List<int>{63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31},
      new List<int>{04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}
    };

    public override long Solve() {
      for(int row = 0; row < triangle.Count; row++) {
        for(int item = 0; item < triangle[row].Count; item++) {
          var upperRightLocationExists = UpperRightLocationExists(row, item);
          var upperLeftLocationExists = UpperLeftLocationExists(row, item);

          if (!upperRightLocationExists && !upperLeftLocationExists) continue;

          if (upperRightLocationExists && upperLeftLocationExists) {
            triangle[row][item] = (int)Math.Max(CurrentNumber(row, item) + UpperRight(row, item), CurrentNumber(row, item) + UpperLeft(row, item));
          }
          else if(!upperRightLocationExists) {
            triangle[row][item] = (int) CurrentNumber(row,item)+ (int)UpperLeft(row, item);
          }
          else if (!upperLeftLocationExists) {
            triangle[row][item] = (int) item + (int)UpperRight(row, item);
          }
        }
      }
      return FindMaxSum();
    }

    long CurrentNumber(int row, int item) {
      return triangle[row][item];
    }

    long FindMaxSum() {
      return triangle.Last().Max();
    }
      
    long UpperLeft(int row, int item) {
      return triangle[row-1][item-1];
    }

    long UpperRight(int row, int item) {
      return triangle[row-1][item];
    }

    bool UpperLeftLocationExists(int y, int x) {
      return (y - 1 < triangle.Count && y - 1 >= 0) && (x - 1 < triangle[y-1].Count && x - 1 >= 0);
    }

    bool UpperRightLocationExists(int y, int x) {
      return (y - 1 < triangle.Count && y - 1 >= 0) && (x < triangle[y-1].Count && x >= 0);
    }
  }
}
