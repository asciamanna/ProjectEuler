using System;

namespace ProjectEuler {
  public abstract class Problem {
    protected DateTime startTime;
    protected DateTime endTime;

    public void SolveToConsole() {
      startTime = DateTime.Now;
      var answer = this.Solve();
      endTime = DateTime.Now;
      WriteAnswer(answer);
      WriteTimeTrackingInfo();
      //Keep console open...
      Console.ReadLine();
    }

    void WriteTimeTrackingInfo() {
      Console.WriteLine("TOTAL TIME:");
      Console.WriteLine("-----------");
      Console.WriteLine(string.Format("Milliseconds: {0}", (endTime - startTime).TotalMilliseconds));
      Console.WriteLine(string.Format("Seconds: {0}", (endTime - startTime).TotalSeconds));
      Console.WriteLine(string.Format("Minutes: {0}", (endTime - startTime).TotalMinutes));
    }

    void WriteAnswer(long answer) {
      Console.WriteLine(string.Format("The answer to Project Euler {0}: {1}", this.GetType().Name, answer));
    }
 
    public abstract long Solve();
  }
}