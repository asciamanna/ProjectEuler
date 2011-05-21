using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProjectEuler {
  public class Problem67 : Problem {
    List<List<long>> triangle;
    
    public override long Solve() {
      BuildInputTriangle();
      return new TriangleMaxRouteSolver(triangle).CacluateSumOfMaxRoute();
    }

    void BuildInputTriangle() {
      try {
        triangle = new List<List<long>>();

        var strings = File.ReadAllLines(@".\Data\triangle.txt").ToList();
        foreach(var row in strings) {
          var rowSplit = row.Split(' ').ToList();
          List<long> rowList = new List<long>();
          foreach (string item in rowSplit) {
            var number = long.Parse(item);
            rowList.Add(number);
          }
          triangle.Add(rowList);
        }
      }
      catch (IOException) {
        Console.WriteLine("Cannot find file on filesystem");
      }
    }
  }
}


