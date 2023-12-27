namespace KataTests;

using System;
using NUnit.Framework;
using Katas;

[TestFixture]
public class WhichAreInTests {

  [TestCase(new string[] { "arp", "live", "strong" },
            new string[] { "lively", "alive", "harp", "sharp", "armstrong" }, 
            new string[] { "arp", "live", "strong" },
            TestName = "arp_live_strong_found")]
  [TestCase(new string[] { "tarp", "mice", "bull" },
            new string[] { "lively", "alive", "harp", "sharp", "armstrong" }, 
            new string[] { },
            TestName = "none_found")]
  [TestCase(new string[] { "strong", "mice", "live", "bull", "arp" },
            new string[] { "lively", "alive", "harp", "sharp", "armstrong" }, 
            new string[] { "arp", "live", "strong" },
            TestName = "arp_live_strong_sorted_found")]
  public void MyTest(string[] firstSet, string[] secondSet, string[] expected) {
    Assert.That(WhichAreIn.inArray(firstSet, secondSet), Is.EqualTo(expected));
  }
}
