using System;
using System.Collections.Generic;

namespace TurboCollections
{
    public static class TurboSort
    {

        public static void SelectionSort(List<int> list)
        {

            for (int i = 0; i < list.Count - 1; i++) //loop through each number in the list you add, exept the last one.The loop continues aslong i is less then the second last
            {
                int minIndex = i; //storing the smallest number/element
                for (int j = i + 1; j < list.Count; j++) //inner loop that starts from the number after i and checks each number at the end.
                {
                    if (list[j] < list[minIndex]) //J is compared to the minIndex, meaning that minIndex will point to the smallest number
                    {
                        minIndex = j;
                    }
                }

                // Swaping the numbers, to makes sure thet the smallest number is places first. 
                (list[minIndex], list[i]) = (list[i], list[minIndex]);
            }


        }

        public static void Main()
        {
            //the numbers added that should be sorted
            List<int> myList = new List<int> { 5, 3, 1, 2, 4 };

            // Call the SelectionSort method
            SelectionSort(myList);

            // Print the sorted list to the console
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }

        }

    }
}
               
                                                 


