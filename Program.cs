using System;

class FirstAssignment
{
    static void Main(string[] args)
    {
        int[] arr;
        if (args.Length != 3 || args[0] != "sort" || args[1] != "-Bubble" && args[1] != "-Merge")
        {
            Console.WriteLine("Input not correct. Correct version: sort -Bubble “1,4,2,3” or  sort -Merge “1,4,2,3”");
            return;
        }
        else
             arr = ParseInput(args[2]);
        //to call the bubble sort function, the input should be -Bubble
        if (args[1] == "-Bubble")
        {
            BubbleSorter sorter = new BubbleSorter();
            sorter.Sort(arr); //calling the bubble sort, passing the numbers the user gave us
            PrintArray(arr);
        }
        //to call the merge sort function, the input should be -Merge
        else if (args[1] == "-Merge")
        {
            MergeSorter sorter = new MergeSorter();
            sorter.Sort(arr, 0, arr.Length - 1);
            PrintArray(arr);
        }
    }

    //parsing the string input into the list of numbers
    static int[] ParseInput(string input)
    {
        string[] numbers = input.Split(',');
        int[] arr = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            arr[i] = int.Parse(numbers[i]);
        }

        return arr;
    }

    //function to print the array after sorting, passing the array 
    static void PrintArray(int[] arr)
    {
        Console.WriteLine("This is your sorted array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        return;
    }
}

