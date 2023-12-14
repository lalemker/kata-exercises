namespace KataTests;

  using NUnit.Framework;
  using System;
  using Katas;

  [TestFixture]
  public class Tests
  {
    [TestCase("a clash of KINGS", "a an the of", "A Clash of Kings")]
    [TestCase("THE WIND IN THE WILLOWS", "The In", "The Wind in the Willows")]
    [TestCase("aBC deF Ghi",null,"Abc Def Ghi")]
    public void MyTest(string sampleTitle, string sampleMinorWords, string expected)
    {
      Assert.That(TitleCaseExercise.TitleCase(sampleTitle, sampleMinorWords), Is.EqualTo(expected));
    }
    [Test]
    public void MyTest2()
    {
      Assert.That(TitleCaseExercise.TitleCase(""), Is.EqualTo(""));
    }

    [Test]
    public void MyTest3()
    {
      Assert.That(TitleCaseExercise.TitleCase("the quick brown fox"), Is.EqualTo("The Quick Brown Fox"));
    }

    [Test]
    public void MyTest4()
    {
      Assert.That(TitleCaseExercise.TitleCase("  "), Is.EqualTo(""));
    }

  }