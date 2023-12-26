namespace KataTests;

using NUnit.Framework;

[TestFixture]
public class MultiplesThreeFiveTests
{
  [Test]
  public void SampleTests()
  {
    Assertion(expected : 23, input : 10);
    Assertion(expected : 78, input : 20);
    Assertion(expected : 9168, input : 200);
    Assertion(expected : 0, input : 0);
    Assertion(expected : 0, input : -1);
  }
  
  private static void Assertion(int expected, int input) =>
    Assert.That(
      MultiplesThreeFive.Solution(input), Is.EqualTo(expected),
      $"Value: {input}"
    );
}