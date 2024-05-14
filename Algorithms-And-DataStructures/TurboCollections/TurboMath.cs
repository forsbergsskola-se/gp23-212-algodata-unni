namespace TurboCollections;

public class TurboMath
{
    public static IEnumerable<int> GetEvenNumbersList(int maxNumber)
    {
        for (int i = 0; i < maxNumber; i++)
        {
            if (i % 2 ==0)
            {
                yield return i;
            }
            
        }
    }
    
    
    public static IEnumerable<int> GetEvenNumbers(int maxNumber){

    }
    
    
}