namespace TurboCollections;

public class TurboMath
{
    public static IEnumerable<int> GetEvenNumbers(int maxNumber)
    {
        for (int i = 0; i < maxNumber; i++)
        {
            if (i % 2 ==0)
            {
                yield return i;
            }
            
        }
    }
    
    
    public static List<int> GetEvenNumbersList(int maxNumber)
    {
        List<int> evenNumbers = new List<int>();
        for (int i = 0; i < maxNumber; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers.Add(i);
            }

            
        }
        return evenNumbers;
    }
    
    
}