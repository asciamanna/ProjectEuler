using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler {
  public class Problem55 : Problem {
    //http://en.wikipedia.org/wiki/Lychrel_number
    //all one and two digit numbers resolve to palindromes thus aren't lychrel
    int startingNumber = 100; 
    int maxIterations = 50;
    int numberOfLychrelNumbers = 0;
    int numberLimit = 10000;
    
    public override long Solve() {
      for (long currentNumber = startingNumber; currentNumber < numberLimit; currentNumber++) {
        var isLychrel = true;
        BigInteger sum = currentNumber;
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
        }
      }
      return numberOfLychrelNumbers;
    }
  }
}
