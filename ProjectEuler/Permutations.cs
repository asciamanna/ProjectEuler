using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public static class Permutations {
    
    public static List<long> Generate(long number) {
      var perms = new List<long>();
      GeneratePerms("", number.ToString(), perms);
      return perms;
    }

    static void GeneratePerms(string beginning, string shuffle, List<long> perms) {
      if (shuffle.Length <= 1)
        perms.Add(long.Parse(beginning + shuffle));
      else {
        for (int i = 0; i < shuffle.Length; i++) {
          shuffle = shuffle.Substring(i, 1) +
                    shuffle.Substring(0, i) +
                    shuffle.Substring(i + 1);

          GeneratePerms(beginning + shuffle.Substring(0, 1),
               shuffle.Substring(1), perms);
        }
      }
    }

    public static List<long> GenerateNumberRotations(long number) {
      var rotations = new List<long>();
      var listOfChars = number.ToString().ToList();

      int i = 0;
      while (i < listOfChars.Count) {
        listOfChars = RotateOnce(listOfChars);
        rotations.Add(long.Parse(new String(listOfChars.ToArray())));
        i++;
      }
      return rotations;
    }


    static List<char> RotateOnce(List<char> list) {
      var firstElement = list[0];
      list.RemoveAt(0);
      list.Add(firstElement);
      return list;
    }
  }
}
