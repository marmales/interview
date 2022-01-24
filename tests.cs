using NUnit.Framework;
using NUnit.Framework.Internal;

namespace interview;

[TestFixture]
public class tests
{
    private static object[] TestInput = {
        new object[] { new[] { 1, 2, 3, 4, 5 }, 4, 5 },
        new object[] { new[] { 5, 5, 4, 11, 10 }, 10, 11 },
        new object[] { new[] { 2, 11, 44, 4, 2 }, 11, 44 },
    };
        
    [TestCaseSource(nameof(TestInput))]
    public void SimpleData(int[] input, int nextMax, int max)
    {
        var result = MaxAndNextMax.Calculate(input).ToArray();

        Assert.That(result[0], Is.EqualTo(nextMax));
        Assert.That(result[1], Is.EqualTo(max));
    }
}