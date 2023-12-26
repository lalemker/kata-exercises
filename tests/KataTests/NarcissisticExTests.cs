namespace KataTests;

using Katas;
using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class NarcissisticTests
{
    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(1)
                            .Returns(true)
                            .SetDescription("1 is narcissistic");
            yield return new TestCaseData(371)
                            .Returns(true)
                            .SetDescription("371 is narcissistic");
            yield return new TestCaseData(370)
                            .Returns(true)
                            .SetDescription("370 is narcissistic");
            yield return new TestCaseData(1634)
                            .Returns(true)
                            .SetDescription("1634 is narcissistic");

        }
    }

    [Test, TestCaseSource(nameof(testCases))]
    public bool Test(int n) => NarcissisticExercise.Narcissistic(n);
}