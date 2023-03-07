using System;

class FirstAssignment
{
    static void Main(string[] args)
    {

        if (args.Length != 3 || args[0] != "sort" || args[1] != "-Bubble" && args[1] != "-Merge")
        {
            Console.WriteLine("Input not correct. Check the documentation to be inspired for the input format");
            return;
        }
        //to call the bubble sort function, the input should be -Bubble
        if (args[1] == "-Bubble")
        {
            int[] arr = ParseInput(args[2]);
            BubbleSort(arr); //calling the bubble sort, passing the numbers the user gave us
            PrintArray(arr);
        }
        //to call the merge sort function, the input should be -Merge
        else if (args[1] == "-Merge")
        {
            int[] arr = ParseInput(args[2]);
            MergeSort(arr, 0, arr.Length - 1);
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


    //Bubble sort brings the biggest number to the end by comparing each number at each index, if its greater, they swap
    static void BubbleSort(int[] unsortedArray)
    {
        int length = unsortedArray.Length;
        int temp;
        int position;
        bool swapped = true; //need to check if the number has been swapped

        //the loop goes to the length of the array - 1 because we are comparing to the number after the current number -> no need to go to the last position as there is no number after it
        for (int i = 0; i < length - 1; i++)
        {
            swapped = false;
            position = length - i - 1; //adding i to not go to the last element as that has already been moved to the right

            for (int j = 0; j < position; j++)
            {
                if (unsortedArray[j] > unsortedArray[j + 1])
                { //if current element is greater than the next one, swap it forward

                    temp = unsortedArray[j];
                    unsortedArray[j] = unsortedArray[j + 1];
                    unsortedArray[j + 1] = temp;
                    swapped = true;
                }
            }

            //if no swap was made during the iteration, the array is already sorted
            if (swapped == false)
            {
                break;
            }
        }
    }

    //the algorithm splits the arrays until we got two arrays of one element each
    //recursively sort the left and right halves of the array
    static void MergeSort(int[] arr, int left, int right)
    {
        //when the function is called for the first time, left = 0 and right = the length of the array - 1, so in the beginning, the array is always divided into two parts
        if (left < right)
        {
            int mid = (left + right) / 2; //calculating the middle index of the array

            MergeSort(arr, left, mid); //recursively sort the left half of the array
            MergeSort(arr, mid + 1, right); //recursively sort the right half of the array

            Merge(arr, left, mid, right);
        }
    }

    //Merge the two sorted halves into a single sorted array
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int i, j, k;
        int sizeLeft = mid - left + 1; //the size of the left subarray
        int sizeRight = right - mid; // the size of the right subarray

        int[] tempLeft = new int[sizeLeft]; //temporary array for the left subarray
        int[] temptRight = new int[sizeRight]; //temporary array for the right subarray

        for (i = 0; i < sizeLeft; i++)
        { //copying the left subarray to the temporary 
            tempLeft[i] = arr[left + i];
        }

        for (j = 0; j < sizeRight; j++)
        { //copying the right subarray to the temporary 
            temptRight[j] = arr[mid + 1 + j];
        }

        i = 0; // index for calculating for left array
        j = 0; //index for calculating the right array
        k = left; //the index of the initial array


        while (i < sizeLeft && j < sizeRight)
        {
            if (tempLeft[i] <= temptRight[j])
            { //comparing each element on each index, 
                arr[k] = tempLeft[i]; //if element from left array is smaller, write it to the initial array
                i++;
            }
            else
            {
                arr[k] = temptRight[j];
                j++;
            }

            k++;
        }

        while (i < sizeLeft)
        { //if there are any elements remaining in the left subarray, copy them to the initial array
            arr[k] = tempLeft[i];
            i++;
            k++;
        }

        while (j < sizeRight)
        { //if there are any elements remaining in the right subarray, copy them to the initial array
            arr[k] = temptRight[j];
            j++;
            k++;
        }
    }
}

