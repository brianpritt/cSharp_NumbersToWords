using System;
using System.Collections.Generic;

namespace NumberToWords.Objects
{
  public class Number
  {
    public int UserNumber {get; set;}
    public string WordNumber {get; set;}

    public Number(int userNumber)
    {
      this.UserNumber = userNumber;
      this.WordNumber = "";
    }

    public string ToWords()
    {
      Dictionary<int, string> onesDict = new Dictionary<int, string>()
      {
        {1, "one"},{2, "two"},{3, "three"},{4,"four"},{5, "five"},{6, "six"},{7, "seven"},{8, "eight"},
        {9, "nine"}
      };
      Dictionary<int, string> tensDict = new Dictionary<int, string>()
      {
        {10, "ten"},{11, "eleven"},{12, "twelve"},{13, "thirteen"},{14, "fourteen"},{15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"}
      };
      if (userNumber.Length)
      foreach (var kvp in onesDict)
      {
        if (UserNumber == kvp.Key)
        {
          WordNumber += kvp.Value;
        }
      }
      Console.WriteLine(WordNumber);
      return WordNumber;
    }
  }
}
