using TurboCollections;

namespace TurboCollectionTest;

public class TurboMathTest
{
    [Test]
    public void GetEvenNumberTest()
    {
        var even = TurboMath.GetEvenNumbers(10);
        Assert.AreEqual(new List<int>{0, 2, 4, 6, 8, 10}, even.ToList());
    }

    [Test]
    public void GetEvenNumberList()
    {
        var evenList = TurboMath.GetEvenNumbersList(10);
        Assert.AreEqual(new List<int>{0, 2, 4, 6, 8, 10}, evenList);
    }
    
}