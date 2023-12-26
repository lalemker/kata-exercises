using System.Collections.Generic;
using System.Linq;

public static class MultiplesThreeFive
{
  public static int Solution(int value)
    {
      if (value <= 0) return 0;

      var listMultiples = new List<int>();

      for (int i = 0; i < value; i += 3)
      {
          listMultiples.Add(i);
      }

      for (int i = 0; i < value; i += 5)
      {
        listMultiples.Add(i);
      }

      return listMultiples.Distinct().Sum();
    }
}