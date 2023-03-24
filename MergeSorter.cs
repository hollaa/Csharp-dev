// MergeSort class implements the ISortAlgorithm interface and provides the implementation of the Sort method for merge sort.
// T : IComparable<T> specifies that the type T must implement the IComparable<T> interface, which allows comparison of objects of type T.
public class MergeSort<T> : ISortAlgorithm<T> where T : IComparable<T>
{
    public T[] Sort(T[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }

        //Divide the array into two halves
        int mid = array.Length / 2; //calculating the middle index of the array
        T[] leftArray = new T[mid];
        T[] rightArray = new T[array.Length - mid];

        //Copy the first half of the original array into the left array
        for (int i = 0; i < mid; i++)
        {
            leftArray[i] = array[i];
        }

        //Copy the second half of the original array into the right array
        for (int i = mid; i < array.Length; i++)
        {
            rightArray[i - mid] = array[i];
        }

        leftArray = Sort(leftArray); //recursively sort the left half of the array
        rightArray = Sort(rightArray); //recursively sort the right half of the array

        // Merge the sorted left and right arrays into a single sorted array.

        int leftIndex = 0; // index for calculating for left array
        int rightIndex = 0; // index for calculating for right array
        int mergedIndex = 0; //the index of the initial array
        T[] mergedArray = new T[array.Length];

        while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
        {
            // Compare the elements in the left and right arrays, and place them in the merged array in sorted order.

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
        // Copy any remaining elements from the left array into the merged array.
        while (leftIndex < leftArray.Length)
        {
            mergedArray[mergedIndex] = leftArray[leftIndex];
            leftIndex++;
            mergedIndex++;
        }

        // Copy any remaining elements from the right array into the merged array.
        while (rightIndex < rightArray.Length)
        {
            mergedArray[mergedIndex] = rightArray[rightIndex];
            rightIndex++;
            mergedIndex++;
        }

        return mergedArray;
    }
}
