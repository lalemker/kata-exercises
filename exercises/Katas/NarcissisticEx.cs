namespace Katas;

using System;
using System.Linq;


public class NarcissisticExercise
{
    public static bool Narcissistic(int value)
    {
        var collNumbers = value.ToString().ToCharArray().ToList().Select(x => int.Parse(x.ToString())).ToList();
        var appliedPower = collNumbers.Count();
        var collNarcNumberCalcs = collNumbers.Select(x => Math.Pow(x, appliedPower)).ToList();
        var narcNumber = collNarcNumberCalcs.Sum();
        return value == narcNumber;
    }
}