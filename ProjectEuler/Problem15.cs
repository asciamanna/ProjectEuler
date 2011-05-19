using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem15 : Problem {
    //------------------------------------
    // Starting in the top left corner of a 2x2 grid, 
    // there are 6 routes (without backtracking) to the bottom right corner.
    //How many routes are there through a 20x20 grid?
    //---------------------------------------
    readonly long gridSize;
    public Problem15(long gridSize) {
      this.gridSize = gridSize;
    }
    public override long Solve() {
      //starting top left and moving to bottom right can only 
      //go east (e) or south(s).  to travel to the bottom right
      //you need to travel exactly N e and N s for a N x N grid.
      //Therefore, the total number of routes is all of the permutations
      //N e and N s
      //N! / (A! * B!) where N = total numbers, with some number repeated A times and another number repeated B times.
      // 40! / (20! * 20!) because it would take 20 e routes and 20 s routes.
      var easternRoutes = gridSize;
      var southernRoutes = gridSize;

      return (long)(EulerMath.Factorial(2*gridSize) / (EulerMath.Factorial(easternRoutes) * EulerMath.Factorial(southernRoutes)));
    }
  }
}
