using System;

namespace ProjectEuler {
  public abstract class Problem {
    protected DateTime startTime;
    protected DateTime endTime;

    public void SolveToConsole() {
      startTime = DateTime.Now;
      var answer = this.Solve();
      endTime = DateTime.Now;
      Console.WriteLine(string.Format("The answer to Project Euler Problem: {0}",answer));
      Console.WriteLine(string.Format("Total Seconds to Run: {0}", (endTime - startTime).TotalSeconds));
      //keep the console open.
      Console.ReadLine();
    }
 
    public abstract int Solve();
  }
}