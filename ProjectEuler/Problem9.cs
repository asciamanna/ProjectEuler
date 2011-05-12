using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem9 : Problem {
    //-------------------------------
    //A Pythagorean triple is a set of three natural numbers, a<b<c, for which,
    //a2 + b2 = c2
    //For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

    //There exists exactly one Pythagorean triple for which a + b + c = 1000.
    //Find the product abc.
    //-------------------------------
    //using this formula to generate pythagorean triples:
    //n^2 - m^2, 2mn, and n^2 + m^2
    //where m < n
    //http://www.math.uic.edu/~fields/puzzle/triples.html

    public override long Solve() {
      int timesThroughLoop = 0;
      
      for (int n = 2; n < int.MaxValue; n++) {
        timesThroughLoop++;//or n -1 can be used...
        for (int m = 1; m <= timesThroughLoop; m++) {
          var triple = PythagoreanTriple.GenerateTriple(m, n);
          if (triple.A + triple.B + triple.C == 1000) {
            return triple.A * triple.B * triple.C;
          }
        }
      }
      return 0;
    }
  }
}
