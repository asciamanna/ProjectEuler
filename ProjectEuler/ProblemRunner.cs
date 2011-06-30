using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows;

namespace ProjectEuler {
  public class ProblemRunner {
    int problemToRun;
    DateTime start;
    DateTime end;
    bool runAll;
    Assembly assembly;
    const int NUM_SLOWEST = 10;
    Dictionary<int, DateTime> timings;

    public ProblemRunner(int problemToRun) {
      this.problemToRun = problemToRun;
      timings = new Dictionary<int, DateTime>();
    }

    public ProblemRunner() {
      this.runAll = true;
    }

    public void Run() {
      assembly = Assembly.GetExecutingAssembly();
      var allProblemTypes = assembly.GetTypes()
             .Where(t => !t.IsAbstract && t.Name.ToLower().StartsWith("problem")).OrderBy(t => t.Name);
      if (runAll) {
        foreach (var eulerProblem in allProblemTypes) {
          SolveProblem(eulerProblem);
        }
      }
      else {
        var type = allProblemTypes.FirstOrDefault(t => t.Name == string.Format("Problem{0}", problemToRun));
        if (type == null) {
          WriteNoProblemText(problemToRun);
        }
        else {
        SolveProblem(type);
        }
      }
    }

    void WriteNoProblemText(int missingProblemNumber) {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(string.Format("Problem {0} does not exist.  Please select a different problem", missingProblemNumber));
      Console.ResetColor();
    }

    void SolveProblem(Type type) {
      var problem = assembly.CreateInstance(type.FullName);
      var method = type.GetMethod("Solve");
      start = DateTime.Now;
      var answer = (long)method.Invoke(problem, null);
      end = DateTime.Now;
      Clipboard.SetText(answer.ToString());
      WriteTimingData(type, answer);
    }

    void WriteTimingData(Type type, long answer) {
      Console.WriteLine("The answer to Project Euler " + type.Name + ": " + answer);
      Console.WriteLine("TOTAL TIME:");
      Console.WriteLine("-----------");
      Console.WriteLine(string.Format("Milliseconds: {0}", (end - start).TotalMilliseconds));
      Console.WriteLine(string.Format("Seconds: {0}", (end - start).TotalSeconds));
      Console.WriteLine(string.Format("Minutes: {0}", (end - start).TotalMinutes));
      Console.WriteLine("=========================================================");
      Console.WriteLine();
    }
  }
}