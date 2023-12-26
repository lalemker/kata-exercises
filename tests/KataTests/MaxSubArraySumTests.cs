namespace KataTests;

using Katas;
using NUnit.Framework;
using System;
[TestFixture]
public class MaxSubArrayTest
{
  [TestCase(new int[0],0,Description = "Single Zero in Array")]
  [TestCase(new int[]{-2, 1, -3, 4, -1, 2, 1, -5, 4},6,Description = "Combination Array")]
  [TestCase(new int[]{-1,-2,-3},0, Description = "All Negative Array")]
  [TestCase(new int[]{-1,-2,-3,1,-1,1,2,-2,-1,0},3, Description = "Combination Array 2")]
  [TestCase(new int[]{5, -6, -1, 2, 3, -4, 8, -9, 10},10,Description = "Combination Array 3")]
  public void MyTest(int[] input, int expected)
  {
    Assert.That(MaxSubArraySum.MaxSequence(input), Is.EqualTo(expected));
  }
}
