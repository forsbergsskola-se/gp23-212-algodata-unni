using System;
using System.Collections.Generic;

namespace TurboCollections
{
    public static class TurboSort
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

                // Swap the itemst
                (list[minIndex], list[i]) = (list[i], list[minIndex]);
            }

    
        }
        
    }
    
}
               
                                                 


