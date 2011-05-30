using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  [EulerProblem(18, "")]
  public class Problem18 : Problem {
    List<List<long>> triangle = new List<List<long>> {
      new List<long>{75},
      new List<long>{95, 64},
      new List<long>{17, 47, 82},
      new List<long>{18, 35, 87, 10},
      new List<long>{20, 04, 82, 47, 65},
      new List<long>{19, 01, 23, 75, 03, 34},
      new List<long>{88, 02, 77, 73, 07, 63, 67},
      new List<long>{99, 65, 04, 28, 06, 16, 70, 92},
      new List<long>{41, 41, 26, 56, 83, 40, 80, 70, 33},
      new List<long>{41, 48, 72, 33, 47, 32, 37, 16, 94, 29},
      new List<long>{53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14},
      new List<long>{70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57},
      new List<long>{91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48},
      new List<long>{63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31},
      new List<long>{04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}
    };

    public override long Solve() {
      return new TriangleMaxRouteSolver(triangle).CacluateSumOfMaxRoute();
    }
  }
}
