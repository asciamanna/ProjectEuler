using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProjectEuler {
  public class Problem42 : Problem {
    public override long Solve() {
      var words = File.ReadAllText(@".\Data\Problem42\words.txt").Replace("\"", string.Empty).Split(',').ToList();
      var triangleNumbers = GenerateTriangleNumbers();
      long numberOfTriangleWords = 0;
      foreach (var word in words) {
        if (triangleNumbers.Contains(ConvertToWordValue(word))) {
          numberOfTriangleWords++;
        }
      }
      return numberOfTriangleWords;
    }

    int ConvertToWordValue(string word) {
      int wordValue = 0;
      foreach (var letter in word) {
        wordValue += letter.ToAlphabeticalPosition();
      }
      return wordValue;
    }

    HashSet<int> GenerateTriangleNumbers() {
      var numbers = new HashSet<int>();
      for (int n = 1; n < 1000000; n++) {
        numbers.Add((int)(.5 * n * (n + 1)));
      }
      return numbers;
    }
  }
}
