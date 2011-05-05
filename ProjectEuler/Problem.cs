using System;

namespace ProjectEuler {
  public class Problem {
    public void WriteAnswerToConsole(string answerString) {
      Console.WriteLine(answerString);
      //keep the console open.
      Console.ReadLine();
    }
  }
}