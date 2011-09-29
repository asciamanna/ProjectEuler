using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProjectEuler {
  public class Problem59 : Problem {
    public override long Solve() {
      //a 97 - z 122 
      const int keyLength = 3;
      var decryptedData = new List<int>();
      var encryptedData = File.ReadAllText(@"C:\development\ProjectEuler\ProjectEuler\Data\Problem59\cipher1.txt").Split(',').ToList().Select(num => int.Parse(num)).ToList();
      for (int a = 97; a <= 122; a++) {
        for (int b = 97; b <= 122; b++) {
          for (int c = 97; c <= 122; c++) {
            decryptedData.Clear();
            for (int i = 0; i < encryptedData.Count(); i += keyLength) {
              decryptedData.Add(a ^ encryptedData[i]);
              if (i + 1 < encryptedData.Count()) {
                decryptedData.Add(b ^ encryptedData[i + 1]);
              }
              if (i + 2 < encryptedData.Count()) {
                decryptedData.Add(c ^ encryptedData[i + 2]);
              }
            }
            if (TextIsEnglish(decryptedData)) {
              foreach (var thing in decryptedData) {
                Console.Write(Convert.ToChar(thing));
              }
              Console.Write(Environment.NewLine);
              Console.WriteLine("Key is: " + Convert.ToChar(a).ToString() + Convert.ToChar(b) + Convert.ToChar(c));
              Console.ReadKey();
            }
          }
        }
      }


      return 0;
    }

    bool TextIsEnglish(List<int> decryptedData) {
      var decryptedText = decryptedData.Select(d => Convert.ToChar(d));
      return decryptedText.All(dt => (dt >= 65 && dt <= 122) || dt == 32 || dt == 33 || dt == 46);
    }
  }
}
