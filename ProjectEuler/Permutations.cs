using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler {
  public static class Permutations<T> {

    public static List<List<T>> Generate(List<T> list) {
      var items = list;
      List<List<T>> listOfPermutations = new List<List<T>>();
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

    static List<T> swap(List<T> list, int i, int j) {
      T nextItem = list[j];
      list[j] = list[i];
      list[i] = nextItem;
      return list;
    }
  }
}
