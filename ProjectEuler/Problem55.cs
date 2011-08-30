using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public class Problem55 : Problem {
    //http://en.wikipedia.org/wiki/Lychrel_number
    //all one and two digit numbers resolve to palindromes thus aren't lychrel
    int maxIterations = 50;
    int numberOfLychrelNumbers = 0;
    int numberLimit = 10000;
    int startingNumber = 100; 

    public override long Solve() {
      for (long testNumber = startingNumber; testNumber < numberLimit; testNumber++) {
        var isLychrel = true;
        long sum = testNumber;
        for (int i = 0; i < maxIterations; i++) {
          if ((sum + sum.Reverse()).IsPalindromic()) {
            isLychrel = false;
            break;
          }
          else {
            sum = sum + sum.Reverse();
          }
          
        }
        if (isLychrel) {
          numberOfLychrelNumbers++;
          Console.WriteLine("Lychrael Number: {0}", testNumber);
          Console.ReadKey();
        }
      }

      return numberOfLychrelNumbers;
    }
  }
}
