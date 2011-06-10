using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public static class Permutations {

    public static List<List<T>> Generate<T>(List<T> list) {
      var items = list;
      var listOfPermutations = new List<List<T>>();
      int i = 0;
      while (i < items.Count) {
        for (int j = 0; j < items.Count - 1; j++) {
          items = swap(items, j, j + 1);
          listOfPermutations.Add(new List<T>(items));
        }
        i++;
      }
      return listOfPermutations;
    }

    public static List<long> GenerateForNumbers(long number) {
      var permutations = new List<long>();
      int i = 0;
      var listofChars = number.ToString().ToList();
      while (i < listofChars.Count) {
        for (int j = 0; j < listofChars.Count - 1; j++) {
          listofChars = swap(listofChars, j, j + 1);
          permutations.Add(long.Parse(new String(listofChars.ToArray())));
        }
        i++;
      }
      return permutations;
    }

    static List<T> swap<T>(List<T> list, int i, int j) {
      T nextItem = list[j];
      list[j] = list[i];
      list[i] = nextItem;
      return list;
    }
  }
}
