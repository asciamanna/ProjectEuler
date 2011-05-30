using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class EulerProblem : Attribute {
    string description;
    int number;

    public EulerProblem(int number, string description) {
      this.number = number;
      this.description = description;
    }
  }
}
