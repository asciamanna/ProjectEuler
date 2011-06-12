using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class PythagoreanTriple {
    private PythagoreanTriple(int a, int b, int c) {
      this.A = a;
      this.B = b;
      this.C = c;
    }
    public int A { get; private set; }
    public int B { get; private set; }
    public int C { get; private set; }

    public static PythagoreanTriple GenerateTriple(int m, int n) {
      if (m >= n) {
        throw new ArgumentException(string.Format("m:{0} must be less than n:{0} to generate a pythagorean triple", m, n));
      }
      //using this formula to generate pythagorean triples:
      //n^2 - m^2, 2mn, and n^2 + m^2
      //where m < n
      //http://www.math.uic.edu/~fields/puzzle/triples.html
      return new PythagoreanTriple(n * n - m * m, 2 * m * n, n * n + m * m);
    }
  }
}
