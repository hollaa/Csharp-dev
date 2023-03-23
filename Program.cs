using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 4 || args[0] != "sort" || (args[1] != "-Bubble" && args[1] != "-Merge"))
        {
            Console.WriteLine(args.Length);
            Console.WriteLine("Input not correct. Correct version: sort -Bubble/-Merge -int/-double/-string “1,4,2,3” or sort -Bubble/-Merge -int/-double/-string 1 4 2 3");
            return;
        }
        if (!IsValidType(args[2]))
        {
            Console.WriteLine("Invalid type specified.");
            return;
        }

        switch (args[1])
        {
            case "-Bubble":
                if (args[2] == "-string")
                {
                    string[] arr = args[3].Split(',');
                    BubbleSort<string> bs = new BubbleSort<string>();
                    string[] arrayyyy = bs.Sort(arr);
                    PrintArray(arrayyyy);
                }
                if (args[2] == "-int")
                {
                    int[] arr = args[3].Split(',').Select(int.Parse).ToArray<int>();
                    BubbleSort<int> bs = new BubbleSort<int>();
                    int[] arrayyyy = bs.Sort(arr);
                    Console.WriteLine("hello");
                    PrintArray(arrayyyy);
                }
                break;
            case "-Merge":
               if (args[2] == "-string") {
                    string[] arr = args[3].Split(',');
                    MergeSort<string> ms = new MergeSort<string>();
                    string[] arrayyyy= ms.Sort(arr);
                    PrintArray(arrayyyy);
                }
                if (args[2] == "-int") {
                    int[] arr = args[3].Split(',').Select(int.Parse).ToArray<int>();
                    MergeSort<int> ms = new MergeSort<int>();
                    int[] arrayyyy = ms.Sort(arr);
                    PrintArray(arrayyyy);
                }
                break;
            default:
                Console.WriteLine("Invalid sorting algorithm specified.");
                return;
        }

        
    }


    static void PrintArray<T>(T[] arr)
    {
        Console.WriteLine("This is your sorted array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    static bool IsValidType(string type)
    {
        return type == "-int" || type == "-double" || type == "-string";
    }
}

public interface ISortAlgorithm<T>
{
    T[] Sort(T[] arr);
}

public class BubbleSort<T> : ISortAlgorithm<T> where T : IComparable<T>
{
    public T[] Sort(T[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    T temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
        }
        return array;
    }
}

public class MergeSort<T> : ISortAlgorithm<T> where T : IComparable<T>
{
    public T[] Sort(T[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }

        int middleIndex = array.Length / 2;
        T[] leftArray = new T[middleIndex];
        T[] rightArray = new T[array.Length - middleIndex];

        for (int i = 0; i < middleIndex; i++)
        {
            leftArray[i] = array[i];
        }

        for (int i = middleIndex; i < array.Length; i++)
        {
            rightArray[i - middleIndex] = array[i];
        }

        leftArray = Sort(leftArray);
        rightArray = Sort(rightArray);

        int leftIndex = 0;
        int rightIndex = 0;
        int mergedIndex = 0;
        T[] mergedArray = new T[array.Length];

        while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
        {
            if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) <= 0)
            {
                mergedArray[mergedIndex] = leftArray[leftIndex];
                leftIndex++;
            }
            else
            {
                mergedArray[mergedIndex] = rightArray[rightIndex];
                rightIndex++;
            }
            mergedIndex++;
        }

        while (leftIndex < leftArray.Length)
        {
            mergedArray[mergedIndex] = leftArray[leftIndex];
            leftIndex++;
            mergedIndex++;
        }

        while (rightIndex < rightArray.Length)
        {
            mergedArray[mergedIndex] = rightArray[rightIndex];
            rightIndex++;
            mergedIndex++;
        }

        return mergedArray;
    }
}
