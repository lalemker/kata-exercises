
namespace Katas;

using System.Linq;

public class WhichAreIn
{
    public static string[] inArray(string[] array1, string[] array2)
    {
      return array1.Where(x => array2.Any(itm => itm.Contains(x))).Select(x => x).OrderBy(x => x).ToArray();;
    }
}
