namespace _213_Selection_Sort;

public class TurboSort
{
    public static void SelectionSort(List<int> list)             
    {                                                            
        for (int i = 0; i < list.Count - 1; i++)                
        {                                                       
            int minIndex = i;                                  
            for (int j = i + 1; j < list.Count; j++)           
            {                                                  
                if (list[j] < list[minIndex])                 
                {                                             
                    minIndex = j;                            
                }                                             
            }                                                  
                                                             
            //change the order of the numbers                  
            int order = list[minIndex];                        
            list[minIndex] = list[i];                          
            list[i] = order;                                   
        }                                                       
                                                             
    }                                                            
}