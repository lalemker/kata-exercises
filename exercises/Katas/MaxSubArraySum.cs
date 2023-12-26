namespace Katas;

using System.Collections.Generic;

public class MaxSubArraySum
{
  public static int MaxSequence(int[] arr) 
  { 
    if (arr.Length == 0) return 0;
    if (!arr.ToList().Where(x => x > 0).Any()) return 0;
    
    var maxSumSoFar = 0;
    var currentSum = 0;

    foreach(var itm in arr) {
      currentSum += itm;
      if (currentSum < 0) currentSum = 0;
      if (currentSum > maxSumSoFar) maxSumSoFar = currentSum;
    }

    return maxSumSoFar;
  }
}
