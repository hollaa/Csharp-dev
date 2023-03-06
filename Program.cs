using System;

class Sort {
    static void Main(string[] args) {

        //to call the bubble sort function, the input should be -Bubble
        if (args[0] == "-Bubble") {
            int[] arr = ParseInput(args[1]);
            BubbleSort(arr); //calling the bubble sort, passing the numbers the user gave us
            PrintArray(arr);
        }
        //to call the merge sort function, the input should be -Merge
        else if (args[0] == "-Merge") {
            int[] arr = ParseInput(args[1]);
            MergeSort(arr, 0, arr.Length - 1); //calling merge sort function, the arguments is the input, the beginning and the end of the array
            PrintArray(arr);
        }

        else {
            Console.WriteLine("Please specify the sort you want. Can be either -Bubble or -Merge.");
        }
        
    }

    static int[] ParseInput(string input) {
        string[] numbers = input.Split(',');
        int[] arr = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++) {
            arr[i] = int.Parse(numbers[i]);
        }

        return arr;
    }

    //function to print the array after sorting, passing the array 
    static void PrintArray(int[] arr) {
        Console.WriteLine("This is your sorted array: ");
        for (int i = 0; i < arr.Length; i++) {
            Console.Write(arr[i] + " ");
        }
        return;
    }

    static void BubbleSort(int[] arr) {
        int length = arr.Length;
        bool swapped;

        for (int i = 0; i < length - 1; i++) {
            swapped = false;

            for (int j = 0; j < length - i - 1; j++) {
                if (arr[j] > arr[j + 1]) {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            if (swapped == false) {
                break;
            }
        }
    }

    static void MergeSort(int[] arr, int left, int right) {
        if (left < right) {
            int mid = (left + right) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right) {
        int i, j, k;
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for (i = 0; i < n1; i++) {
            L[i] = arr[left + i];
        }

        for (j = 0; j < n2; j++) {
            R[j] = arr[mid + 1 + j];
        }

        i = 0;
        j = 0;
        k = left;

        while (i < n1 && j < n2) {
            if (L[i] <= R[j]) {
                arr[k] = L[i];
                i++;
            }
            else {
                arr[k] = R[j];
                j++;
            }

            k++;
        }

        while (i < n1) {
            arr[k] = L[i];
            i++;
            k++;
        }

        while (j < n2) {
            arr[k] = R[j];
            j++;
            k++;
        }
    }
}

//future improvements -> check whether the input is integer, check there are more than 2 numbers inserted 