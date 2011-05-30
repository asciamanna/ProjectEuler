using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemRunner {
   class Program {
    [STAThread] // for OLE
    static void Main(string[] args) {
      Console.Write("Which Project Euler problem do you want to solve (Enter a for all): ");
      var input = Console.ReadLine().Trim();
      int problemToRun = 0;
      if (input.ToLower() == "a") {
        new ProblemRunner().Run();
      }
      else if (input.ToLower().StartsWith("slowest")) {
        //print slowest to screen and file
      }
      else if (int.TryParse(input, out problemToRun)) {
        new ProblemRunner(problemToRun).Run();
      }
      //keep window open
      Console.ReadLine();
    }
  }
}
