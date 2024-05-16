using System;
using System.Collections;
using System.Collections.Generic;
using TurboCollections;

class Iterator
{
    public static void Main()
    {
        // Creating a List with 5 numbers, uning Int
        List<int> numbers = new List<int> { 1, 1, 2, 3, 5 };

        // Assign it to a variable of type IEnumerable
        IEnumerable<int> enumerableNumbers = numbers;
        

        // Use GetEnumerator() and a while-loop to print all elements
        using (var enumerator = enumerableNumbers.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current +" ");
            }
        }

        // To add up all numbers using IEnumerable and print the sum
        int sum = 0;
        
        
        foreach (int number in enumerableNumbers)
        {
            sum += number;
        }
        
        Console.WriteLine("Sum: " + sum);

        List<int> NumbersEven = TurboMath.GetEvenNumbersList(12);
        
        /*foreach (var number in NumbersEven(12))
        {
            Console.WriteLine(number);
        }
*/
        Console.WriteLine("testing with 1_000_000_000");

        foreach (var number in TurboMath.GetEvenNumbers(12))
        {
            Console.WriteLine(number);
        }

        TurboMath.GetEvenNumbers((1000000000));
        TurboMath.GetEvenNumbersList(1000000000);
        

    }

    
        
    }
    
