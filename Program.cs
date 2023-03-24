using System;

class Program
{
    static void Main(string[] args)
    {
        // Check if the arguments passed to the program are correct
       if (!IsInputValid(args))
        {
            Console.WriteLine("Input not correct. Correct version: sort -Bubble/-Merge -int/-double/-string “1,4,2,3”");
            return;
        }

        // Sort the array depending on the arguments passed
        switch (args[1])
        {
            case "-Bubble":
                //Data input from user is int
                if (args[2] == "-int")
                {
                     // Convert the input string to an int array and sort it using BubbleSort
                    int[] arr = args[3].Split(',').Select(int.Parse).ToArray<int>();
                    BubbleSort<int> bubbleSort = new BubbleSort<int>();
                    int[] sortedArray = bubbleSort.Sort(arr);
                    // Print the sorted array
                    PrintArray(sortedArray);
                }
                //Data input from user is double
                else if(args[2] == "-double")
                {
                    //Convert the input string to an array of double and sort it 
                    double[] arr = args[3].Split(',').Select(double.Parse).ToArray<double>();
                    BubbleSort<double> bubbleSort = new BubbleSort<double>();
                    double[] sortedArray = bubbleSort.Sort(arr);
                    PrintArray(sortedArray);
                }
                //Data input from user is string
                else if (args[2] == "-string")
                {
                    // Convert the input string to a string array and sort it using BubbleSort
                    string[] arr = args[3].Split(',');
                    BubbleSort<string> bubbleSort = new BubbleSort<string>();
                    string[] sortedArray = bubbleSort.Sort(arr);
                    PrintArray(sortedArray);
                }
                //The data type is not recognized
                else
                {
                    Console.WriteLine("Invalid type specified.");
                    return;
                }
                break;
            case "-Merge":
               //data type is int
                if (args[2] == "-int") {
                    //convert the input string and sort it using merge sort
                    int[] arr = args[3].Split(',').Select(int.Parse).ToArray<int>();
                    MergeSort<int> ms = new MergeSort<int>();
                    int[] sortedArray = ms.Sort(arr);
                    PrintArray(sortedArray);
                }
                //data type is double
                else if(args[2] == "-double"){
                    //convert the input string and sort it using merge sort
                    double[] arr = args[3].Split(',').Select(double.Parse).ToArray<double>();
                    MergeSort<double> mergeSort = new MergeSort<double>();
                    double[] sortedArray = mergeSort.Sort(arr);
                    PrintArray(sortedArray);
                }
                else if (args[2] == "-string") {
                    //convert the input string and sort it using merge sort
                    string[] arr = args[3].Split(',');
                    MergeSort<string> mergeSort = new MergeSort<string>();
                    string[] sortedArray = mergeSort.Sort(arr);
                    PrintArray(sortedArray);
                }
                break;
            default:
                Console.WriteLine("Invalid sorting algorithm specified.");
                return;
        }
    }

    // The PrintArray method takes a generic array as its parameter and prints the sorted array to the console.
    static void PrintArray<T>(T[] arr)
    {
        Console.WriteLine("This is your sorted array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    //The method IsInputValid takes the input as its parameter and checks whether it is valid
    static bool IsInputValid(string[] args)
    {
        if (args.Length != 4) return false;
        if (args[0] != "sort") return false;
        if (args[1] != "-Bubble" && args[1] != "-Merge") return false;
        if (!int.TryParse(args[3], out int result) && !args[3].Contains(',')) return false;
        return true;
    }
}