using System;

namespace ProjectEuler {
  public abstract class Problem {
    public void WriteAnswerToConsole(string answerString) {
      Console.WriteLine(answerString);
      //keep the console open.
      Console.ReadLine();
    }

    public abstract void Solve();
  }
}