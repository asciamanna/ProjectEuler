using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

namespace ProblemRunner {
  public class ProblemRunner {
    int problemToRun;
    DateTime start;
    DateTime end;

    public ProblemRunner(int problemToRun) {
      this.problemToRun = problemToRun;
    }

    public void Run() {
      var assembly = Assembly.LoadFrom(@"C:\development\ProjectEuler\ProjectEuler\bin\debug\ProjectEuler.exe");
      var type = assembly.GetTypes().Where(t => t.Name == string.Format("Problem{0}", problemToRun)).First();
      var problem = assembly.CreateInstance(type.FullName);
      var method = type.GetMethod("SolveToConsole");
      method.Invoke(problem, null);
      Console.ReadLine();
    }
  }
}